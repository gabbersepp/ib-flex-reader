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
        private  IStreamBuilder sb;

        
        public Reader()
        {
            sb = new StreamBuilder();
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="convertedXmlFile"></param>
        /// <param name="options"></param>
        /// <returns>An object with account activities</returns>
        public Contracts.FlexQueryResponse GetByString(string convertedXmlFile, Options options = null)
        {

            var stream = this.sb.GenerateStreamFromString(convertedXmlFile);

            var result = Deserializer.Deserialize<Xml.Contracts.FlexQueryResponse, Contracts.FlexQueryResponse>(stream, out var errorObjects);
            result = result ?? new Contracts.FlexQueryResponse();
            result.Errors = errorObjects;
            Logic.ProcessStatement(result.FlexStatements?.FlexStatement, options);

            return result;
        }



        
        public async Task<FlexResult> GetByApi(string token, string queryId)
        {
            // todo: cover this code with tests
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


    }
}
