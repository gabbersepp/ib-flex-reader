using System.Collections.Generic;
using System.Xml.Serialization;

namespace IbFlexReader.Xml.Contracts
{
    [XmlRoot(ElementName = "TradeConfirms")]
    public class TradeConfirms
    {
        [XmlElement(ElementName = "TradeConfirm")]
        public List<TradeConfirm> TradeConfirm { get; set; }
    }
}