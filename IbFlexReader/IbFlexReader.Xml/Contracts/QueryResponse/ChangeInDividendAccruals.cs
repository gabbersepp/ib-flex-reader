namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "ChangeInDividendAccruals")]
    public class ChangeInDividendAccruals
    {
        [XmlElement(ElementName = "ChangeInDividendAccrual")]
        public List<ChangeInDividendAccrual> ChangeInDividendAccrual { get; set; }
    }
}