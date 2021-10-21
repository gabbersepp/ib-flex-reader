namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "FxPositions")]
    public class FxPositions
    {
        [XmlElement(ElementName = "FxPosition")]
        public List<FxPosition> FxPosition { get; set; }

        [XmlElement(ElementName = "FxLots")]
        public FxLots FxLots { get; set; }
    }
}