namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;
    using IbFlexReader.Contracts.Enums;

    public class StatementOfFundsLine
    {
        public string AccountId { get; set; }
        public string AcctAlias { get; set; }
        public string ActivityCode { get; set; }
        public string ActivityDescription { get; set; }
        public double? Amount { get; set; }
        public AssetCategory? AssetCategory { get; set; }
        public double? Balance { get; set; }
        public BuySell? BuySell { get; set; }
        public long? Conid { get; set; }
        public double? Credit { get; set; }
        public Currencies? Currency { get; set; }
        public string Cusip { get; set; }
        [Format(Constants.DateFormat)]
        public DateTime? Date { get; set; }
        public double? Debit { get; set; }
        public string Description { get; set; }
        [Format(Constants.DateFormat)]
        public DateTime? Expiry { get; set; }
        public double? FxRateToBase { get; set; }
        public string Isin { get; set; }
        public string Issuer { get; set; }
        public string LevelOfDetail { get; set; }
        public string ListingExchange { get; set; }
        public string Model { get; set; }
        public int? Multiplier { get; set; }
        public string OrderID { get; set; }
        public string PrincipalAdjustFactor { get; set; }
        public PutCall? PutCall { get; set; }
        [Format(Constants.DateFormat)]
        public DateTime? ReportDate { get; set; }
        public string SecurityID { get; set; }
        public string SecurityIDType { get; set; }
        [Format(Constants.DateFormat)]
        public DateTime? SettleDate { get; set; }
        public double? Strike { get; set; }
        public string Symbol { get; set; }
        public string TradeCode { get; set; }
        public double? TradeCommission { get; set; }
        public double? TradeGross { get; set; }
        public string TradeID { get; set; }
        public double? TradePrice { get; set; }
        public double? TradeQuantity { get; set; }
        public double? TradeTax { get; set; }
        public long? UnderlyingConid { get; set; }
        public string UnderlyingListingExchange { get; set; }
        public string UnderlyingSecurityID { get; set; }
        public string UnderlyingSymbol { get; set; }
    }
}
