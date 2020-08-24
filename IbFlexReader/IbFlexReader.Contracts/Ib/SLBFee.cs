namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;
    using IbFlexReader.Contracts.Enums;

    public class SLBFee
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

        public string Exchange { get; set; }

        public double? Quantity { get; set; }

        public string Code { get; set; }

        public string ToAcct { get; set; }

        public string FromAcct { get; set; }

        public string Type { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? ValueDate { get; set; }

        public string CollateralAmount { get; set; }

        public string UniqueID { get; set; }

        public double? NetLendFee { get; set; }

        public double? NetLendFeeRate { get; set; }

        public double? GrossLendFee { get; set; }

        public double? MarketFeeRate { get; set; }

        public double? TotalCharges { get; set; }

        public double? TicketCharge { get; set; }

        public double? CarryCharge { get; set; }

        public double? Fee { get; set; }

        public double? FeeRate { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? StartDate { get; set; }
    }
}