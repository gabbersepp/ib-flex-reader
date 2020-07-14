namespace IbFlexReader
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Xml;
    using IbFlexReader.Contracts;
    using IbFlexReader.Contracts.Ib;
    using IbFlexReader.Xml;
    using IbFlexReader.Xml.Contracts;

    public class Reader
    {
        private readonly IStreamBuilder<string> sb;

        public Reader()
        {
            sb = new StringStream();
        }

        /// <summary>
        /// Converts a string to a FlexQueryResponse.
        /// </summary>
        /// <param name="xmlFile"></param>
        /// <param name="options"></param>
        /// <returns>An object with account activities</returns>
        public Contracts.FlexQueryResponse GetByString(string xmlFile, Options options = null)
        {
            if (options != null)
            {
                if (options.UseXmlReader)
                {
                    XmlReaderSettings settings = new XmlReaderSettings
                    {
                        Async = true
                    };

                    using (XmlReader reader = XmlReader.Create(xmlFile, settings))
                    {
                        var result = Deserializer.Deserialize<Xml.Contracts.QueryResponse.FlexQueryResponse, Contracts.FlexQueryResponse>(reader, out var errorObjects);
                        result = result ?? new Contracts.FlexQueryResponse();
                        result.Errors = errorObjects;
                        foreach (FlexStatement statement in result.FlexStatements.FlexStatement)
                        {
                            Logic.ProcessStatement(statement, options);
                        }

                        return result;
                    }
                }
            }

            using (var stream = sb.GenerateStream(xmlFile))
            {
                var result = Deserializer.Deserialize<Xml.Contracts.QueryResponse.FlexQueryResponse, Contracts.FlexQueryResponse>(stream, out var errorObjects);
                result = result ?? new Contracts.FlexQueryResponse();
                result.Errors = errorObjects;
                foreach (FlexStatement statement in result.FlexStatements.FlexStatement)
                {
                    Logic.ProcessStatement(statement, options);
                }

                return result;
            }
        }

        /// <summary>
        /// Reads a FlexQuery by API.
        /// </summary>
        /// <param name="token">token provided by IB</param>
        /// <param name="queryId">ID of the FlexQuery (not the name)</param>
        /// <param name="dumpFile">if set, the data returned from IB will be dumped to file</param>
        /// <param name="retry">if GetStatement returns warning 1019 (... Please try again shortly), retry defines how many times it will be tried again</param>
        /// <param name="retryDelay">delay between two tries in milliseconds</param>
        /// <returns></returns>
        public async Task<FlexResult> GetByApi(string token, string queryId, string dumpFile = null, int? retry = null, int retryDelay = 3000)
        {
            if (retryDelay <= 0)
            {
                throw new ArgumentOutOfRangeException("retryDelay");
            }

            using (var client = new HttpClient())
            {
                FlexResult requestResult = await SendRequest(client, token, queryId, dumpFile).ConfigureAwait(false);

                if (!requestResult.IsSuccess)
                {
                    return requestResult;
                }

                string referenceCode = requestResult.ReferenceCode;

                int retryCounter = 0;
                if (retry.HasValue && retry.Value > 0)
                {
                    retryCounter = retry.Value;
                }

                FlexResult result = null;

                bool tryAgain = true;
                while (tryAgain)
                {
                    result = await GetStatement(client, token, referenceCode, dumpFile).ConfigureAwait(false);

                    if (!result.IsSuccess && result.ErrorCode.HasValue && result.ErrorCode.Value == 1019)
                    {
                        // warning is: 'Statement generation in progress. Please try again shortly. '

                        System.Diagnostics.Debug.Print("IbFlexReader.Reader.GetByApi: Retry");

                        // retry getting data?
                        if (retryCounter > 0)
                        {
                            // yes
                            retryCounter--;
                            // wait a little bit
                            await Task.Delay(retryDelay).ConfigureAwait(false);
                        }
                        else
                        {
                            // no
                            tryAgain = false;
                        }
                    }
                    else
                    {
                        // data received
                        tryAgain = false;
                    }
                }

                return result;
            }
        }

        private async Task<FlexResult> GetStatement(HttpClient client, string token, string referenceCode, string dumpFile)
        {
            var uri = new Uri($"https://gdcdyn.interactivebrokers.com/Universal/servlet/FlexStatementService.GetStatement?q={referenceCode}&t={token}&v=3");

            using (var getStatementResult = await client.PostAsync(uri, null).ConfigureAwait(false))
            using (var stream = await getStatementResult.Content.ReadAsStreamAsync().ConfigureAwait(false))
            {
                if (dumpFile != null)
                {
                    Utils.DumpFileWriter.DumpGetStatement(stream, dumpFile);
                }

                // in case of an error or warning, a FlexStatementResponse object will be returned instead of the data
                if (TryGetFlexStatementResponse(stream, out FlexStatementResponse flexStatementResponse))
                {
                    return new FlexResult
                    {
                        Status = flexStatementResponse.Status,
                        ErrorCode = flexStatementResponse.ErrorCode,
                        ErrorMessage = flexStatementResponse.ErrorMessage
                    };
                }

                var queryResponse = Deserializer.Deserialize<Xml.Contracts.QueryResponse.FlexQueryResponse, Contracts.FlexQueryResponse>(stream, out var errorObjects);

                // in case of an error during deserialization, queryResponse maybe NULL (see PopulateFrom method)
                if (queryResponse == null)
                {
                    if (errorObjects.Count > 0)
                    {
                        System.Text.StringBuilder sb = new System.Text.StringBuilder();
                        errorObjects.ForEach(e => sb.AppendLine(e.Message));
                        throw new Exception(sb.ToString());
                    }
                    else
                    {
                        throw new Exception("deserialization failed");
                    }
                }

                queryResponse.Errors = errorObjects;

                return new FlexResult
                {
                    Status = "Success",
                    FlexQueryResponse = queryResponse
                };
            }
        }

        private async Task<FlexResult> SendRequest(HttpClient client, string token, string queryId, string dumpFile)
        {
            var uri = new Uri($"https://gdcdyn.interactivebrokers.com/Universal/servlet/FlexStatementService.SendRequest?t={token}&q={queryId}&v=3");

            using (var sendRequestResult = await client.PostAsync(uri, null).ConfigureAwait(false))
            using (var stream = await sendRequestResult.Content.ReadAsStreamAsync().ConfigureAwait(false))
            {
                if (dumpFile != null)
                {
                    Utils.DumpFileWriter.DumpSendRequest(stream, dumpFile);
                }

                var response = Deserializer.Deserialize<XmlFlexStatementResponse, FlexStatementResponse>(stream, out var errorObjects);

                if (response == null)
                {
                    if (errorObjects.Count > 0)
                    {
                        System.Text.StringBuilder sb = new System.Text.StringBuilder();
                        errorObjects.ForEach(e => sb.AppendLine(e.Message));
                        throw new Exception(sb.ToString());
                    }
                    else
                    {
                        throw new Exception("deserialization failed");
                    }
                }

                if (response.Status == "Success")
                {
                    return new FlexResult
                    {
                        Status = "Success",
                        ReferenceCode = response.ReferenceCode.Value.ToString()
                    };
                }
                else
                {
                    return new FlexResult
                    {
                        Status = response.Status,
                        ErrorCode = response.ErrorCode,
                        ErrorMessage = response.ErrorMessage
                    };
                }
            }
        }

        private bool TryGetFlexStatementResponse(Stream stream, out FlexStatementResponse response)
        {
            response = null;

            try
            {
                response = Deserializer.Deserialize<XmlFlexStatementResponse, FlexStatementResponse>(stream, out var errorObjects);
                return response != null;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (stream != null)
                {
                    stream.Position = 0;
                }
            }
        }
    }
}
