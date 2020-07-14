namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "ComplexPositions")]
    public class ComplexPositions
    {
        [XmlElement(ElementName = "ComplexPosition")]
        public List<ComplexPosition> ComplexPosition { get; set; }
    }
}
