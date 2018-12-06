using IbFlexReader.Contracts;
using IbFlexReader.Xml;
using IbFlexReader.Xml.Contracts;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace IbFlexReader
{
    public class Reader
    {
        private IStreamBuilder sb;


        public Reader()
        {
            sb = new StreamBuilder();
        }

        /// <summary>
        /// Converts a string to a FlexQueryResponse.
        /// </summary>
        /// <param name="convertedXmlFile"></param>
        /// <param name="options"></param>
        /// <returns>An object with account activities</returns>
        public Contracts.FlexQueryResponse GetByString(string convertedXmlFile, Options options = null)
        {
            using (var stream = this.sb.GenerateStreamFromString(convertedXmlFile))
            {
                var result = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(stream, out var errorObjects);
                result = result ?? new Contracts.FlexQueryResponse();
                result.Errors = errorObjects;
                Logic.ProcessStatement(result.FlexStatements?.FlexStatement, options);

                return result;
            }
        }


        /// <summary>
        /// Reads a FlexQuery by API.
        /// </summary>
        /// <param name="token">token provided by IB</param>
        /// <param name="queryId">ID of the FelxQuery (not the name)</param>
        /// <param name="dumpFile">if set, the data returned from IB will be dumped to file</param>
        /// <returns></returns>
        public async Task<FlexResult> GetByApi(string token, string queryId, string dumpFile = null)
        {
            // todo: cover this code with tests
            using (var client = new HttpClient())
            {
                var uri = new Uri($"https://gdcdyn.interactivebrokers.com/Universal/servlet/FlexStatementService.SendRequest?t={token}&q={queryId}&v=3");

                string referenceCode;
                using (var sendRequestResult = await client.PostAsync(uri, null))
                using (var stream = await sendRequestResult.Content.ReadAsStreamAsync())
                {
                    if (dumpFile != null) { Utils.DumpFileWriter.DumpSendRequest(stream, dumpFile); }

                    var response = Deserializer.Deserialize<XmlFlexStatementResponse, FlexStatementResponse>(stream, out var errorObjects);

                    if (response.Status != "Success")
                    {
                        return new FlexResult
                        {
                            ErrorCode = response.ErrorCode,
                            ErrorMessage = response.ErrorMessage
                        };
                    }

                    referenceCode = response.ReferenceCode.Value.ToString();
                }


                uri = new Uri($"https://gdcdyn.interactivebrokers.com/Universal/servlet/FlexStatementService.GetStatement?q={referenceCode}&t={token}&v=3");

                using (var getStatementResult = await client.PostAsync(uri, null))
                using (var stream = await getStatementResult.Content.ReadAsStreamAsync())
                {
                    if (dumpFile != null) { Utils.DumpFileWriter.DumpGetStatement(stream, dumpFile); }

                    var queryResponse = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(stream, out var errorObjects);
                    queryResponse.Errors = errorObjects;

                    return new FlexResult
                    {
                        Status = "Success",
                        FlexQueryResponse = queryResponse
                    };
                }
            }
        }
    }
}
