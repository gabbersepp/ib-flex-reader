using System.Collections.Generic;
using System.Xml.Serialization;

namespace IbFlexReader.Xml.Contracts
{
    [XmlRoot(ElementName = "OpenPositions")]
    public class OpenPositions
    {
        [XmlElement(ElementName = "OpenPosition")]
        public List<OpenPosition> OpenPosition { get; set; }
    }
}