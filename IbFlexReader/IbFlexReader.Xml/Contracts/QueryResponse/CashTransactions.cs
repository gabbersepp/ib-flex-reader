namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "CashTransactions")]
    public class CashTransactions
    {
        [XmlElement(ElementName = "CashTransaction")]
        public List<CashTransaction> CashTransaction { get; set; }
    }
}