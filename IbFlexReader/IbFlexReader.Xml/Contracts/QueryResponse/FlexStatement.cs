using System.Xml.Serialization;

namespace IbFlexReader.Xml.Contracts
{
    [XmlRoot(ElementName = "FlexStatement")]
    public class FlexStatement
    {
        [XmlElement(ElementName = "AccountInformation")]
        public AccountInformation AccountInformation { get; set; }

        [XmlElement(ElementName = "EquitySummaryInBase")]
        public EquitySummaryInBase EquitySummaryInBase { get; set; }

        [XmlElement(ElementName = "OpenPositions")]
        public OpenPositions OpenPositions { get; set; }

        [XmlElement(ElementName = "Trades")] public Trades Trades { get; set; }

        [XmlElement(ElementName = "TradeConfirms")]
        public TradeConfirms TradeConfirms { get; set; }

        [XmlElement(ElementName = "TransactionTaxes")]
        public string TransactionTaxes { get; set; }

        [XmlElement(ElementName = "OptionEAE")]
        public OptionEAE OptionEAE { get; set; }

        [XmlElement(ElementName = "PriorPeriodPositions")]
        public PriorPeriodPositions PriorPeriodPositions { get; set; }

        [XmlElement(ElementName = "CorporateActions")]
        public string CorporateActions { get; set; }

        [XmlElement(ElementName = "CashTransactions")]
        public CashTransactions CashTransactions { get; set; }

        [XmlElement(ElementName = "CFDCharges")]
        public CFDCharges CFDCharges { get; set; }

        [XmlElement(ElementName = "Transfers")]
        public string Transfers { get; set; }

        [XmlElement(ElementName = "ChangeInDividendAccruals")]
        public ChangeInDividendAccruals ChangeInDividendAccruals { get; set; }

        [XmlElement(ElementName = "OpenDividendAccruals")]
        public OpenDividendAccruals OpenDividendAccruals { get; set; }

        [XmlElement(ElementName = "SecuritiesInfo")]
        public SecuritiesInfo SecuritiesInfo { get; set; }

        [XmlElement(ElementName = "ConversionRates")]
        public ConversionRates ConversionRates { get; set; }

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
    }
}