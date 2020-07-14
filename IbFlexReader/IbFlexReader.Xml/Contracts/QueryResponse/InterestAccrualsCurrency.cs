namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "InterestAccrualsCurrency")]
    public class InterestAccrualsCurrency
    {
        [XmlAttribute(AttributeName = "toDate")]
        public string ToDate { get; set; }

        [XmlAttribute(AttributeName = "fromDate")]
        public string FromDate { get; set; }

        [XmlAttribute(AttributeName = "accountId")]
        public string AccountId { get; set; }

        [XmlAttribute(AttributeName = "acctAlias")]
        public string AcctAlias { get; set; }

        [XmlAttribute(AttributeName = "model")]
        public string Model { get; set; }

        [XmlAttribute(AttributeName = "currency")]
        public string Currency { get; set; }

        [XmlAttribute(AttributeName = "endingAccrualBalance")]
        public string EndingAccrualBalance { get; set; }

        [XmlAttribute(AttributeName = "fxTranslation")]
        public string FxTranslation { get; set; }

        [XmlAttribute(AttributeName = "accrualReversal")]
        public string AccrualReversal { get; set; }

        [XmlAttribute(AttributeName = "interestAccrued")]
        public string InterestAccrued { get; set; }

        [XmlAttribute(AttributeName = "startingAccrualBalance")]
        public string StartingAccrualBalance { get; set; }
    }
}
