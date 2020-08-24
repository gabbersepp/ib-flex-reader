namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "Trades")]
    public class Trades
    {
        [XmlElement(ElementName = "Lot")]
        public List<Lot> Lot { get; set; }

        [XmlElement(ElementName = "Trade")]
        public List<Trade> Trade { get; set; }

        [XmlElement(ElementName = "AssetSummary")]
        public List<AssetSummary> AssetSummary { get; set; }

        [XmlElement(ElementName = "SymbolSummary")]
        public List<SymbolSummary> SymbolSummary { get; set; }

        [XmlElement(ElementName = "Order")]
        public List<Order> Order { get; set; }
    }
}