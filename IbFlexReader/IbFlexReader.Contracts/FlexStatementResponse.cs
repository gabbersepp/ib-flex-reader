namespace IbFlexReader.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class FlexStatementResponse
    {
        public string Status { get; set; }
        public long? ReferenceCode { get; set; }
        public string Url { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
