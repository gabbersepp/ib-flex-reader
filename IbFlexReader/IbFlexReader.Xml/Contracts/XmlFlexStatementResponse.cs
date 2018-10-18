using System.Xml.Serialization;

namespace IbFlexReader.Xml.Contracts
{
    [XmlRoot("FlexStatementResponse")]
    public class XmlFlexStatementResponse : XmlBase
    {  
        public string Status { get; set; }
        public long? ReferenceCode { get; set; }
        public string Url { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
