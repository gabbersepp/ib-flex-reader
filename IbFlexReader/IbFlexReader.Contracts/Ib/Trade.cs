namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;
    using IbFlexReader.Contracts.Enums;

    public class Trade
    {
        public string AccountId { get; set; }

        public string AcctAlias { get; set; }

        public string Model { get; set; }

        public Currencies? Currency { get; set; }

        public double? FxRateToBase { get; set; }

        public AssetCategory? AssetCategory { get; set; }

        public string Symbol { get; set; }

        public string Description { get; set; }

        public long? Conid { get; set; }

        public string SecurityID { get; set; }

        public string SecurityIDType { get; set; }

        public string Cusip { get; set; }

        public string Isin { get; set; }

        public string ListingExchange { get; set; }

        public long? UnderlyingConid { get; set; }

        public string UnderlyingSymbol { get; set; }

        public string UnderlyingSecurityID { get; set; }

        public string UnderlyingListingExchange { get; set; }

        public string Issuer { get; set; }

        public int? Multiplier { get; set; }

        public double? Strike { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? Expiry { get; set; }

        public long? TradeID { get; set; }

        public PutCall? PutCall { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? ReportDate { get; set; }

        public string PrincipalAdjustFactor { get; set; }

        [Format(Constants.DateTimeFormat)]
        [TimeField(nameof(TradeTime))]
        public DateTime? TradeDate { get; set; }

        [Format(Constants.DateTimeFormat)]
        [DateField(nameof(TradeDate))]
        public DateTime? TradeTime { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? SettleDateTarget { get; set; }

        public string TransactionType { get; set; }

        public string Exchange { get; set; }

        public int? Quantity { get; set; }

        public double? TradePrice { get; set; }

        public double? TradeMoney { get; set; }

        public double? Proceeds { get; set; }

        public double? Taxes { get; set; }

        public double? IbCommission { get; set; }

        public Currencies? IbCommissionCurrency { get; set; }

        public double? NetCash { get; set; }

        public double? ClosePrice { get; set; }

        public OpenClose? OpenCloseIndicator { get; set; }

        public Notes? Notes { get; set; }

        public double? Cost { get; set; }

        public double? FifoPnlRealized { get; set; }

        public double? FxPnl { get; set; }

        public double? MtmPnl { get; set; }

        public double? OrigTradePrice { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? OrigTradeDate { get; set; }

        public long? OrigTradeID { get; set; }

        public long? OrigOrderID { get; set; }

        public string ClearingFirmID { get; set; }

        public long? TransactionID { get; set; }

        public BuySell? BuySell { get; set; }

        public long? IbOrderID { get; set; }

        public string IbExecID { get; set; }

        public string BrokerageOrderID { get; set; }

        public string OrderReference { get; set; }

        public string VolatilityOrderLink { get; set; }

        public string ExchOrderId { get; set; }

        public string ExtExecID { get; set; }

        [Format(Constants.DateTimeFormat)]
        public DateTime? OrderTime { get; set; }

        public string OpenDateTime { get; set; }

        public string HoldingPeriodDateTime { get; set; }

        public string WhenRealized { get; set; }

        public string WhenReopened { get; set; }

        public string LevelOfDetail { get; set; }

        public string ChangeInPrice { get; set; }

        public string ChangeInQuantity { get; set; }

        public string OrderType { get; set; }

        public string TraderID { get; set; }

        public string IsAPIOrder { get; set; }
    }
}