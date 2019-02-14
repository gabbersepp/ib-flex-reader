using System.Collections.Generic;
using System.Xml.Serialization;

namespace IbFlexReader.Xml.Contracts
{
    [XmlRoot(ElementName = "PriorPeriodPositions")]
    public class PriorPeriodPositions
    {
        [XmlElement(ElementName = "PriorPeriodPosition")]
        public List<PriorPeriodPosition> PriorPeriodPosition { get; set; }
    }
}