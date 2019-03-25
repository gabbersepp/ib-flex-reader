namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "SecuritiesInfo")]
    public class SecuritiesInfo
    {
        [XmlElement(ElementName = "SecurityInfo")]
        public List<SecurityInfo> SecurityInfo { get; set; }
    }
}