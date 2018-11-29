using IbFlexReader.Contracts;
using IbFlexReader.Xml;
using IbFlexReader.Xml.Contracts;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace IbFlexReader
{
    public class Reader
    {
        public Contracts.FlexQueryResponse GetByString(string content, Options options = null)
        {
            var stream = GenerateStreamFromString(content);
            var result = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(stream, out var errorObjects);
            result = result ?? new Contracts.FlexQueryResponse();
            result.Errors = errorObjects;
            Logic.ProcessStatement(result.FlexStatements?.FlexStatement, options);
            return result;
        }

        public async Task<Contracts.FlexResult> GetByApi(string token, string queryId)
        {
            var client = new HttpClient();
            var uri = new Uri($"https://gdcdyn.interactivebrokers.com/Universal/servlet/FlexStatementService.SendRequest?t={token}&q={queryId}&v=3");
            var result = await client.PostAsync(uri, null);
            var stream = await result.Content.ReadAsStreamAsync();
            var response = Deserializer.Deserialize<XmlFlexStatementResponse, FlexStatementResponse>(stream, out var errorObjects);

            if (response.Status != "Success")
            {
                return new FlexResult
                {
                    ErrorCode = response.ErrorCode,
                    ErrorMessage = response.ErrorMessage
                };
            }

            uri = new Uri($"https://gdcdyn.interactivebrokers.com/Universal/servlet/FlexStatementService.GetStatement?q={response.ReferenceCode}&t={token}&v=3");
            result = await client.PostAsync(uri, null);
            stream = await result.Content.ReadAsStreamAsync();
            var queryResponse = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(stream, out errorObjects);
            queryResponse.Errors = errorObjects;

            return new FlexResult
            {
                Status = "Success",
                FlexQueryResponse = queryResponse
            };
        }

        public static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
