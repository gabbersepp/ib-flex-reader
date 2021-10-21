namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "CorporateActions")]
    public class CorporateActions
    {
        [XmlElement(ElementName = "CorporateAction")]
        public List<CorporateAction> CorporateAction { get; set; }
    }
}
