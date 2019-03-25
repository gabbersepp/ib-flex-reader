namespace IbFlexReader.Xml.Contracts
{
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "FlexStatements")]
    public class FlexStatements
    {
        [XmlElement(ElementName = "FlexStatement")]
        public FlexStatement FlexStatement { get; set; }

        [XmlAttribute(AttributeName = "count")]
        public string Count { get; set; }
    }
}