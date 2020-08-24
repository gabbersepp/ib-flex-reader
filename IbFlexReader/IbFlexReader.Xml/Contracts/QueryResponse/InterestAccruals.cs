namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "InterestAccruals")]
    public class InterestAccruals
    {
        [XmlElement(ElementName = "InterestAccrualsCurrency")]
        public List<InterestAccrualsCurrency> InterestAccrualsCurrency { get; set; }
    }
}
