/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0

 https://xmltocsharp.azurewebsites.net/
 */

namespace IbFlexReader.Contracts
{
    public class FlexQueryResponse
    {

        public FlexStatements FlexStatements { get; set; }

        public string QueryName { get; set; }

        public string Type { get; set; }
    }

}
