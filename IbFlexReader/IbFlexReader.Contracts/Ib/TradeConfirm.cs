namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;
    using IbFlexReader.Contracts.Enums;

    public class TradeConfirm
    {
        public string AccountId { get; set; }

        public string AcctAlias { get; set; }

        public string Model { get; set; }

        public Currencies? Currency { get; set; }

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

        [Format(Constants.DateFormat)]
        public DateTime? SettleDate { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? TradeDate { get; set; }

        public string PrincipalAdjustFactor { get; set; }

        [Format(Constants.DateTimeFormat)]
        public DateTime? DateTime { get; set; }

        public string TransactionType { get; set; }

        public string Exchange { get; set; }

        public int? Quantity { get; set; }

        public double? Proceeds { get; set; }

        public double? Tax { get; set; }

        public double? Commission { get; set; }

        public Currencies? CommissionCurrency { get; set; }

        public double? Price { get; set; }

        public double? Amount { get; set; }

        public double? OrigTradePrice { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? OrigTradeDate { get; set; }

        public long? OrigTradeID { get; set; }

        public string ClearingFirmID { get; set; }

        public BuySell? BuySell { get; set; }

        public long? OrderID { get; set; }

        public string ExecID { get; set; }

        public string BrokerageOrderID { get; set; }

        public string OrderReference { get; set; }

        public string VolatilityOrderLink { get; set; }

        public string ExchOrderId { get; set; }

        [Format(Constants.DateTimeFormat)]
        public DateTime? OrderTime { get; set; }

        public string LevelOfDetail { get; set; }

        public string OrderType { get; set; }

        public string TraderID { get; set; }

        public string IsAPIOrder { get; set; }

        public Notes? Code { get; set; }

        public double? BrokerExecutionCommission { get; set; }

        public double? BrokerClearingCommission { get; set; }

        public double? ThirdPartyExecutionCommission { get; set; }

        public double? ThirdPartyClearingCommission { get; set; }

        public double? ThirdPartyRegulatoryCommission { get; set; }

        public double? OtherCommission { get; set; }

        public string AllocatedTo { get; set; }
    }
}