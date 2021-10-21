namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "FxLots")]
    public class FxLots
    {
        [XmlElement(ElementName = "FxLot")]
        public List<FxLot> FxLot { get; set; }
    }
}