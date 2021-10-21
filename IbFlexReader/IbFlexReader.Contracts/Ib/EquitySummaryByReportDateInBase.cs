namespace IbFlexReader.Contracts.Ib
{
    public class EquitySummaryByReportDateInBase
    {
        public string AccountId { get; set; }

        public string AcctAlias { get; set; }

        public string Model { get; set; }

        //Note: The reportDate XML attribute may contain either a date or a string, i.e. reportDate="MULTI"
        public string ReportDate { get; set; }

        public double? Cash { get; set; }

        public double? CashLong { get; set; }

        public double? CashShort { get; set; }

        public double? SlbCashCollateral { get; set; }

        public double? SlbCashCollateralLong { get; set; }

        public double? SlbCashCollateralShort { get; set; }

        public double? Stock { get; set; }

        public double? StockLong { get; set; }

        public double? StockShort { get; set; }

        public double? SlbDirectSecuritiesBorrowed { get; set; }

        public double? SlbDirectSecuritiesBorrowedLong { get; set; }

        public double? SlbDirectSecuritiesBorrowedShort { get; set; }

        public double? SlbDirectSecuritiesLent { get; set; }

        public double? SlbDirectSecuritiesLentLong { get; set; }

        public double? SlbDirectSecuritiesLentShort { get; set; }

        public double? Options { get; set; }

        public double? OptionsLong { get; set; }

        public double? OptionsShort { get; set; }

        public double? Commodities { get; set; }

        public double? CommoditiesLong { get; set; }

        public double? CommoditiesShort { get; set; }

        public double? Bonds { get; set; }

        public double? BondsLong { get; set; }

        public double? BondsShort { get; set; }

        public double? Notes { get; set; }

        public double? NotesLong { get; set; }

        public double? NotesShort { get; set; }

        public double? Funds { get; set; }

        public double? FundsLong { get; set; }

        public double? FundsShort { get; set; }

        public double? InterestAccruals { get; set; }

        public double? InterestAccrualsLong { get; set; }

        public double? InterestAccrualsShort { get; set; }

        public double? SoftDollars { get; set; }

        public double? SoftDollarsLong { get; set; }

        public double? SoftDollarsShort { get; set; }

        public double? ForexCfdUnrealizedPl { get; set; }

        public double? ForexCfdUnrealizedPlLong { get; set; }

        public double? ForexCfdUnrealizedPlShort { get; set; }

        public double? CfdUnrealizedPl { get; set; }

        public double? CfdUnrealizedPlLong { get; set; }

        public double? CfdUnrealizedPlShort { get; set; }

        public double? DividendAccruals { get; set; }

        public double? DividendAccrualsLong { get; set; }

        public double? DividendAccrualsShort { get; set; }

        public double? FdicInsuredBankSweepAccountCashComponent { get; set; }

        public double? FdicInsuredBankSweepAccountCashComponentLong { get; set; }

        public double? FdicInsuredBankSweepAccountCashComponentShort { get; set; }

        public double? FdicInsuredAccountInterestAccrualsComponent { get; set; }

        public double? FdicInsuredAccountInterestAccrualsComponentLong { get; set; }

        public double? FdicInsuredAccountInterestAccrualsComponentShort { get; set; }

        public double? Total { get; set; }

        public double? TotalLong { get; set; }

        public double? TotalShort { get; set; }

        public string BrokerCashComponent             { get; set; }
        public string IpoSubscription                 { get; set; }
        public string IpoSubscriptionLong             { get; set; }
        public string IpoSubscriptionShort            { get; set; }
        public string BrokerInterestAccrualsComponent { get; set; }
        public string BondInterestAccrualsComponent   { get; set; }
        public string BrokerFeesAccrualsComponent     { get; set; }
    }
}