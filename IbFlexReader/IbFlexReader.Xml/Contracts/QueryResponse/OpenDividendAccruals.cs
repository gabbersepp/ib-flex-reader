using System.Xml.Serialization;

namespace IbFlexReader.Xml.Contracts
{
    [XmlRoot(ElementName = "OpenDividendAccruals")]
    public class OpenDividendAccruals
    {
        [XmlElement(ElementName = "OpenDividendAccrual")]
        public OpenDividendAccrual OpenDividendAccrual { get; set; }
    }
}