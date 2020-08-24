namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;
    using IbFlexReader.Contracts.Enums;

    public class Transfer
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

        //Note: The reportDate XML attribute may contain either a date or a string, i.e. reportDate="MULTI"
        public string ReportDate { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? Date { get; set; }

        [Format(Constants.DateTimeFormat, 0)]
        // alternative format
        [Format(Constants.DateFormat, 1)]
        public DateTime? TradeDateTime { get; set; }

        public string Type { get; set; }

        public string Direction { get; set; }

        public string Company { get; set; }

        public string Account { get; set; }

        public string AccountName { get; set; }

        public double? Quantity { get; set; }

        public double? TransferPrice { get; set; }

        public double? PositionAmount { get; set; }

        public double? PositionAmountInBase { get; set; }

        public double? PnlAmount { get; set; }

        public double? PnlAmountInBase { get; set; }

        public double? FxPnl { get; set; }

        public double? CashTransfer { get; set; }

        public string Code { get; set; }

        public string ClientReference { get; set; }

        public long? TransactionID { get; set; }
    }
}
