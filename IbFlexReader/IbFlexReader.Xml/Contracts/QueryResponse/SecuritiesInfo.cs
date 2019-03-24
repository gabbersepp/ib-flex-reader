using System.Collections.Generic;
using System.Xml.Serialization;

namespace IbFlexReader.Xml.Contracts
{
    [XmlRoot(ElementName = "SecuritiesInfo")]
    public class SecuritiesInfo
    {
        [XmlElement(ElementName = "SecurityInfo")]
        public List<SecurityInfo> SecurityInfo { get; set; }
    }
}