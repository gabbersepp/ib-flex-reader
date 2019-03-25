namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "OpenPositions")]
    public class OpenPositions
    {
        [XmlElement(ElementName = "OpenPosition")]
        public List<OpenPosition> OpenPosition { get; set; }
    }
}