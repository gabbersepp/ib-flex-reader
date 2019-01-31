using System.Collections.Generic;
using System.Xml.Serialization;

namespace IbFlexReader.Xml.Contracts
{
    [XmlRoot(ElementName = "Trades")]
    public class Trades
    {
        [XmlElement(ElementName = "Lot")] public List<Lot> Lot { get; set; }

        [XmlElement(ElementName = "Trade")] public List<Trade> Trade { get; set; }
    }
}