namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "SLBFees")]
    public class SLBFees
    {
        [XmlElement(ElementName = "SLBFee")]
        public List<SLBFee> SLBFee { get; set; }
    }
}
