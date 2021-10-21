namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "OpenDividendAccruals")]
    public class OpenDividendAccruals
    {
        [XmlElement(ElementName = "OpenDividendAccrual")]
        public List<OpenDividendAccrual> OpenDividendAccrual { get; set; }
    }
}