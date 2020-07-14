namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "TierInterestDetail")]
    public class TierInterestDetail
    {
        [XmlAttribute(AttributeName = "accountId")]
        public string AccountId { get; set; }

        [XmlAttribute(AttributeName = "acctAlias")]
        public string AcctAlias { get; set; }

        [XmlAttribute(AttributeName = "model")]
        public string Model { get; set; }

        [XmlAttribute(AttributeName = "currency")]
        public string Currency { get; set; }

        [XmlAttribute(AttributeName = "fxRateToBase")]
        public string FxRateToBase { get; set; }

        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }

        [XmlAttribute(AttributeName = "toAcct")]
        public string ToAcct { get; set; }

        [XmlAttribute(AttributeName = "fromAcct")]
        public string FromAcct { get; set; }

        [XmlAttribute(AttributeName = "totalInterest")]
        public string TotalInterest { get; set; }

        [XmlAttribute(AttributeName = "ibuklInterest")]
        public string IbuklInterest { get; set; }

        [XmlAttribute(AttributeName = "commoditiesInterest")]
        public string CommoditiesInterest { get; set; }

        [XmlAttribute(AttributeName = "securitiesInterest")]
        public string SecuritiesInterest { get; set; }

        [XmlAttribute(AttributeName = "rate")]
        public string Rate { get; set; }

        [XmlAttribute(AttributeName = "totalPrincipal")]
        public string TotalPrincipal { get; set; }

        [XmlAttribute(AttributeName = "ibuklPrincipal")]
        public string IbuklPrincipal { get; set; }

        [XmlAttribute(AttributeName = "commoditiesPrincipal")]
        public string CommoditiesPrincipal { get; set; }

        [XmlAttribute(AttributeName = "securitiesPrincipal")]
        public string SecuritiesPrincipal { get; set; }

        [XmlAttribute(AttributeName = "balanceThreshold")]
        public string BalanceThreshold { get; set; }

        [XmlAttribute(AttributeName = "tierBreak")]
        public string TierBreak { get; set; }

        [XmlAttribute(AttributeName = "valueDate")]
        public string ValueDate { get; set; }

        [XmlAttribute(AttributeName = "interestType")]
        public string InterestType { get; set; }
    }
}
