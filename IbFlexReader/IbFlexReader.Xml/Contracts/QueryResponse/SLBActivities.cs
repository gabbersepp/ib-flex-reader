namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "SLBActivities")]
    public class SLBActivities
    {
        [XmlElement(ElementName = "SLBActivity")]
        public List<SLBActivity> SLBActivity { get; set; }
    }
}
