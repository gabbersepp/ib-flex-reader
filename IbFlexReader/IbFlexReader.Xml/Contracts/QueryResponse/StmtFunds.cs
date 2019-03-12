using System.Collections.Generic;
using System.Xml.Serialization;

namespace IbFlexReader.Xml.Contracts
{
    [XmlRoot(ElementName = "StmtFunds")]
    public class StmtFunds
    {
        [XmlElement(ElementName = "StatementOfFundsLine")]
        public List<StatementOfFundsLine> StatementOfFundsLine { get; set; }
    }
}
