/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0

 https://xmltocsharp.azurewebsites.net/
 */

namespace IbFlexReader.Contracts
{
    public class ConversionRate
    {

        public string ReportDate { get; set; }

        public string FromCurrency { get; set; }

        public string ToCurrency { get; set; }

        public string Rate { get; set; }
    }

}
