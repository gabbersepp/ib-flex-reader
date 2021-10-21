namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "FxTransactions")]
    public class FxTransactions
    {
        [XmlElement(ElementName = "FxTransaction")]
        public List<FxTransaction> FxTransaction { get; set; }

        [XmlElement(ElementName = "FxClosedLots")]
        public List<FxClosedLots> FxClosedLots { get; set; }
    }
}