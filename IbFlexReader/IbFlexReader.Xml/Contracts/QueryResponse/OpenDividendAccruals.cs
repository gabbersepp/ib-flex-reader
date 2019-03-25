namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "OpenDividendAccruals")]
    public class OpenDividendAccruals
    {
        [XmlElement(ElementName = "OpenDividendAccrual")]
        public OpenDividendAccrual OpenDividendAccrual { get; set; }
    }
}