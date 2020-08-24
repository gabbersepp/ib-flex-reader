namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "FlexStatements")]
    public class FlexStatements
    {
        [XmlElement(ElementName = "FlexStatement")]
        public List<FlexStatement> FlexStatement { get; set; }

        [XmlAttribute(AttributeName = "count")]
        public string Count { get; set; }
    }
}