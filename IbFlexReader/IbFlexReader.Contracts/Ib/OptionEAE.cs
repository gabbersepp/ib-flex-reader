namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;
    using IbFlexReader.Contracts.Enums;

    public class OptionEAE
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

        public PutCall? PutCall { get; set; }

        public string PrincipalAdjustFactor { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? Date { get; set; }

        public string TransactionType { get; set; }

        public double? Quantity { get; set; }

        public double? TradePrice { get; set; }

        public double? MarkPrice { get; set; }

        public double? Proceeds { get; set; }

        public double? CommisionsAndTax { get; set; }

        public double? CostBasis { get; set; }

        public double? RealizedPnl { get; set; }

        public double? FxPnl { get; set; }

        public double? MtmPnl { get; set; }

        public string TradeID { get; set; }
    }
}