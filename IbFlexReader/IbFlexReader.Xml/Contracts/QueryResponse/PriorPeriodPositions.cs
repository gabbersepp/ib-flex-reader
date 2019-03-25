namespace IbFlexReader.Xml.Contracts
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "PriorPeriodPositions")]
    public class PriorPeriodPositions
    {
        [XmlElement(ElementName = "PriorPeriodPosition")]
        public List<PriorPeriodPosition> PriorPeriodPosition { get; set; }
    }
}