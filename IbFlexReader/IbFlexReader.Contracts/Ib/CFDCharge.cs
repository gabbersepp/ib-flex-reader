namespace IbFlexReader.Contracts.Ib
{
    public class CFDCharge
    {
        public string AccountId { get; set; }

        public string AcctAlias { get; set; }

        public string Model { get; set; }

        public string Currency { get; set; }

        public string FxRateToBase { get; set; }

        public string AssetCategory { get; set; }

        public string Symbol { get; set; }

        public string Description { get; set; }

        public string Conid { get; set; }

        public string SecurityID { get; set; }

        public string SecurityIDType { get; set; }

        public string Cusip { get; set; }

        public string Isin { get; set; }

        public string ListingExchange { get; set; }

        public string UnderlyingConid { get; set; }

        public string UnderlyingSymbol { get; set; }

        public string UnderlyingSecurityID { get; set; }

        public string UnderlyingListingExchange { get; set; }

        public string Issuer { get; set; }

        public string Multiplier { get; set; }

        public string Strike { get; set; }

        public string Expiry { get; set; }

        public string PutCall { get; set; }

        public string PrincipalAdjustFactor { get; set; }

        public string Date { get; set; }

        public string Received { get; set; }

        public string Paid { get; set; }

        public string Total { get; set; }

        public string TransactionID { get; set; }
    }
}