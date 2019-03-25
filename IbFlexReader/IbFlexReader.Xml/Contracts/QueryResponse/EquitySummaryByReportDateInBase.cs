namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "EquitySummaryByReportDateInBase")]
    public class EquitySummaryByReportDateInBase
    {
        [XmlAttribute(AttributeName = "accountId")]
        public string AccountId { get; set; }

        [XmlAttribute(AttributeName = "acctAlias")]
        public string AcctAlias { get; set; }

        [XmlAttribute(AttributeName = "model")]
        public string Model { get; set; }

        [XmlAttribute(AttributeName = "reportDate")]
        public string ReportDate { get; set; }

        [XmlAttribute(AttributeName = "cash")]
        public string Cash { get; set; }

        [XmlAttribute(AttributeName = "cashLong")]
        public string CashLong { get; set; }

        [XmlAttribute(AttributeName = "cashShort")]
        public string CashShort { get; set; }

        [XmlAttribute(AttributeName = "slbCashCollateral")]
        public string SlbCashCollateral { get; set; }

        [XmlAttribute(AttributeName = "slbCashCollateralLong")]
        public string SlbCashCollateralLong { get; set; }

        [XmlAttribute(AttributeName = "slbCashCollateralShort")]
        public string SlbCashCollateralShort { get; set; }

        [XmlAttribute(AttributeName = "stock")]
        public string Stock { get; set; }

        [XmlAttribute(AttributeName = "stockLong")]
        public string StockLong { get; set; }

        [XmlAttribute(AttributeName = "stockShort")]
        public string StockShort { get; set; }

        [XmlAttribute(AttributeName = "slbDirectSecuritiesBorrowed")]
        public string SlbDirectSecuritiesBorrowed { get; set; }

        [XmlAttribute(AttributeName = "slbDirectSecuritiesBorrowedLong")]
        public string SlbDirectSecuritiesBorrowedLong { get; set; }

        [XmlAttribute(AttributeName = "slbDirectSecuritiesBorrowedShort")]
        public string SlbDirectSecuritiesBorrowedShort { get; set; }

        [XmlAttribute(AttributeName = "slbDirectSecuritiesLent")]
        public string SlbDirectSecuritiesLent { get; set; }

        [XmlAttribute(AttributeName = "slbDirectSecuritiesLentLong")]
        public string SlbDirectSecuritiesLentLong { get; set; }

        [XmlAttribute(AttributeName = "slbDirectSecuritiesLentShort")]
        public string SlbDirectSecuritiesLentShort { get; set; }

        [XmlAttribute(AttributeName = "options")]
        public string Options { get; set; }

        [XmlAttribute(AttributeName = "optionsLong")]
        public string OptionsLong { get; set; }

        [XmlAttribute(AttributeName = "optionsShort")]
        public string OptionsShort { get; set; }

        [XmlAttribute(AttributeName = "commodities")]
        public string Commodities { get; set; }

        [XmlAttribute(AttributeName = "commoditiesLong")]
        public string CommoditiesLong { get; set; }

        [XmlAttribute(AttributeName = "commoditiesShort")]
        public string CommoditiesShort { get; set; }

        [XmlAttribute(AttributeName = "bonds")]
        public string Bonds { get; set; }

        [XmlAttribute(AttributeName = "bondsLong")]
        public string BondsLong { get; set; }

        [XmlAttribute(AttributeName = "bondsShort")]
        public string BondsShort { get; set; }

        [XmlAttribute(AttributeName = "notes")]
        public string Notes { get; set; }

        [XmlAttribute(AttributeName = "notesLong")]
        public string NotesLong { get; set; }

        [XmlAttribute(AttributeName = "notesShort")]
        public string NotesShort { get; set; }

        [XmlAttribute(AttributeName = "funds")]
        public string Funds { get; set; }

        [XmlAttribute(AttributeName = "fundsLong")]
        public string FundsLong { get; set; }

        [XmlAttribute(AttributeName = "fundsShort")]
        public string FundsShort { get; set; }

        [XmlAttribute(AttributeName = "interestAccruals")]
        public string InterestAccruals { get; set; }

        [XmlAttribute(AttributeName = "interestAccrualsLong")]
        public string InterestAccrualsLong { get; set; }

        [XmlAttribute(AttributeName = "interestAccrualsShort")]
        public string InterestAccrualsShort { get; set; }

        [XmlAttribute(AttributeName = "softDollars")]
        public string SoftDollars { get; set; }

        [XmlAttribute(AttributeName = "softDollarsLong")]
        public string SoftDollarsLong { get; set; }

        [XmlAttribute(AttributeName = "softDollarsShort")]
        public string SoftDollarsShort { get; set; }

        [XmlAttribute(AttributeName = "forexCfdUnrealizedPl")]
        public string ForexCfdUnrealizedPl { get; set; }

        [XmlAttribute(AttributeName = "forexCfdUnrealizedPlLong")]
        public string ForexCfdUnrealizedPlLong { get; set; }

        [XmlAttribute(AttributeName = "forexCfdUnrealizedPlShort")]
        public string ForexCfdUnrealizedPlShort { get; set; }

        [XmlAttribute(AttributeName = "cfdUnrealizedPl")]
        public string CfdUnrealizedPl { get; set; }

        [XmlAttribute(AttributeName = "cfdUnrealizedPlLong")]
        public string CfdUnrealizedPlLong { get; set; }

        [XmlAttribute(AttributeName = "cfdUnrealizedPlShort")]
        public string CfdUnrealizedPlShort { get; set; }

        [XmlAttribute(AttributeName = "dividendAccruals")]
        public string DividendAccruals { get; set; }

        [XmlAttribute(AttributeName = "dividendAccrualsLong")]
        public string DividendAccrualsLong { get; set; }

        [XmlAttribute(AttributeName = "dividendAccrualsShort")]
        public string DividendAccrualsShort { get; set; }

        [XmlAttribute(AttributeName = "fdicInsuredBankSweepAccountCashComponent")]
        public string FdicInsuredBankSweepAccountCashComponent { get; set; }

        [XmlAttribute(AttributeName = "fdicInsuredBankSweepAccountCashComponentLong")]
        public string FdicInsuredBankSweepAccountCashComponentLong { get; set; }

        [XmlAttribute(AttributeName = "fdicInsuredBankSweepAccountCashComponentShort")]
        public string FdicInsuredBankSweepAccountCashComponentShort { get; set; }

        [XmlAttribute(AttributeName = "fdicInsuredAccountInterestAccrualsComponent")]
        public string FdicInsuredAccountInterestAccrualsComponent { get; set; }

        [XmlAttribute(AttributeName = "fdicInsuredAccountInterestAccrualsComponentLong")]
        public string FdicInsuredAccountInterestAccrualsComponentLong { get; set; }

        [XmlAttribute(AttributeName = "fdicInsuredAccountInterestAccrualsComponentShort")]
        public string FdicInsuredAccountInterestAccrualsComponentShort { get; set; }

        [XmlAttribute(AttributeName = "total")]
        public string Total { get; set; }

        [XmlAttribute(AttributeName = "totalLong")]
        public string TotalLong { get; set; }

        [XmlAttribute(AttributeName = "totalShort")]
        public string TotalShort { get; set; }
    }
}