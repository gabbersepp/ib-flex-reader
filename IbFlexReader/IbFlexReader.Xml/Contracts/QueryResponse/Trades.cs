namespace IbFlexReader.Xml.Contracts
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
    }
}