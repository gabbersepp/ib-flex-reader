namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "StmtFunds")]
    public class StmtFunds
    {
        [XmlElement(ElementName = "StatementOfFundsLine")]
        public List<StatementOfFundsLine> StatementOfFundsLine { get; set; }
    }
}
