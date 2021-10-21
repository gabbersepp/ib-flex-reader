namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "FlexStatement")]
    public class FlexStatement
    {
        [XmlElement(ElementName = "AccountInformation")]
        public AccountInformation AccountInformation { get; set; }

        [XmlElement(ElementName = "CashTransactions")]
        public CashTransactions CashTransactions { get; set; }

        [XmlElement(ElementName = "CFDCharges")]
        public CFDCharges CFDCharges { get; set; }

        [XmlElement(ElementName = "ChangeInDividendAccruals")]
        public ChangeInDividendAccruals ChangeInDividendAccruals { get; set; }

        [XmlElement(ElementName = "ComplexPositions")]
        public ComplexPositions ComplexPositions { get; set; }

        [XmlElement(ElementName = "ConversionRates")]
        public ConversionRates ConversionRates { get; set; }

        [XmlElement(ElementName = "CorporateActions")]
        public CorporateActions CorporateActions { get; set; }

        [XmlElement(ElementName = "EquitySummaryInBase")]
        public EquitySummaryInBase EquitySummaryInBase { get; set; }

        [XmlElement(ElementName = "InterestAccruals")]
        public InterestAccruals InterestAccruals { get; set; }

        [XmlElement(ElementName = "OpenDividendAccruals")]
        public OpenDividendAccruals OpenDividendAccruals { get; set; }

        [XmlElement(ElementName = "OpenPositions")]
        public OpenPositions OpenPositions { get; set; }

        //Note: IB does not pluralize the containing OptionEAE in the FlexStatement so we get <OptionEAE><OptionEAE></OptionEAE>...</OptionEAE>
        [XmlElement(ElementName = "OptionEAE")]
        public OptionEAEs OptionEAEs { get; set; }

        [XmlElement(ElementName = "PriorPeriodPositions")]
        public PriorPeriodPositions PriorPeriodPositions { get; set; }

        [XmlElement(ElementName = "SecuritiesInfo")]
        public SecuritiesInfo SecuritiesInfo { get; set; }

        [XmlElement(ElementName = "SLBActivities")]
        public SLBActivities SLBActivities { get; set; }

        [XmlElement(ElementName = "SLBFees")]
        public SLBFees SLBFees { get; set; }

        [XmlElement(ElementName = "StmtFunds")]
        public StmtFunds StatementOfFunds { get; set; }

        [XmlElement(ElementName = "TierInterestDetails")]
        public TierInterestDetails TierInterestDetails { get; set; }

        [XmlElement(ElementName = "TradeConfirms")]
        public TradeConfirms TradeConfirms { get; set; }

        [XmlElement(ElementName = "Trades")]
        public Trades Trades { get; set; }

        [XmlElement(ElementName = "TransactionTaxes")]
        public TransactionTaxes TransactionTaxes { get; set; }

        [XmlElement(ElementName = "Transfers")]
        public Transfers Transfers { get; set; }

        [XmlElement(ElementName = "UnbundledCommissionDetails")]
        public UnbundledCommissionDetails UnbundledCommissionDetails { get; set; }

        [XmlAttribute(AttributeName = "accountId")]
        public string AccountId { get; set; }

        [XmlAttribute(AttributeName = "fromDate")]
        public string FromDate { get; set; }

        [XmlAttribute(AttributeName = "toDate")]
        public string ToDate { get; set; }

        [XmlAttribute(AttributeName = "period")]
        public string Period { get; set; }

        [XmlAttribute(AttributeName = "whenGenerated")]
        public string WhenGenerated { get; set; }

        [XmlElement(ElementName = "FxPositions")]
        public FxPositions FxPositions { get; set; }

        [XmlElement(ElementName = "FxTransactions")]
        public FxTransactions FxTransactions { get; set; }
    }
}