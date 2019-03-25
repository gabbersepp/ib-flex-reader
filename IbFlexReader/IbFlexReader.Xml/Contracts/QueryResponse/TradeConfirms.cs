namespace IbFlexReader.Xml.Contracts
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "TradeConfirms")]
    public class TradeConfirms
    {
        [XmlElement(ElementName = "TradeConfirm")]
        public List<TradeConfirm> TradeConfirm { get; set; }
    }
}