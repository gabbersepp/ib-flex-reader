namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "UnbundledCommissionDetails")]
    public class UnbundledCommissionDetails
    {
        [XmlElement(ElementName = "UnbundledCommissionDetail")]
        public List<UnbundledCommissionDetail> UnbundledCommissionDetail { get; set; }
    }
}
