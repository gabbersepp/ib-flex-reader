namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "TierInterestDetails")]
    public class TierInterestDetails
    {
        [XmlElement(ElementName = "TierInterestDetail")]
        public List<TierInterestDetail> TierInterestDetail { get; set; }
    }
}
