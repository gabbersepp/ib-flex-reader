namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "FlexQueryResponse")]
    public class FlexQueryResponse : XmlBase
    {
        [XmlElement(ElementName = "FlexStatements")]
        public FlexStatements FlexStatements { get; set; }

        [XmlAttribute(AttributeName = "queryName")]
        public string QueryName { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }
}