using System.Collections.Generic;
using System.Xml.Serialization;

namespace IbFlexReader.Xml.Contracts
{
    [XmlRoot(ElementName = "CashTransactions")]
    public class CashTransactions
    {
        [XmlElement(ElementName = "CashTransaction")]
        public List<CashTransaction> CashTransaction { get; set; }
    }
}