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
        public Contracts.FlexQueryResponse GetByString(string content)
        {
            var stream = GenerateStreamFromString(content);
            return new Deserializer().Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(stream);
        }

        public async Task<Contracts.FlexResult> GetByApi(string token, string queryId)
        {
            var client = new HttpClient();
            var uri = new Uri($"https://gdcdyn.interactivebrokers.com/Universal/servlet/FlexStatementService.SendRequest?t={token}&q={queryId}&v=3");
            var result = await client.PostAsync(uri, null);
            var stream = await result.Content.ReadAsStreamAsync();
            var response = new Deserializer().Deserialize<XmlFlexStatementResponse, FlexStatementResponse>(stream);

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
            var queryResponse = new Deserializer().Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(stream);

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
