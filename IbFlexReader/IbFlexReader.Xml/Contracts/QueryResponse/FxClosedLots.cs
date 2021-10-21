namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "FxClosedLots")]
    public class FxClosedLots
    {
        [XmlElement(ElementName = "FxClosedLot")]
        public List<FxClosedLot> FxClosedLot { get; set; }
    }
}