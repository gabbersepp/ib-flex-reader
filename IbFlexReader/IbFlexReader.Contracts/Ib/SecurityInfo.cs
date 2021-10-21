namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;
    using IbFlexReader.Contracts.Enums;

    public class SecurityInfo
    {
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

        public string Maturity { get; set; }

        public string IssueDate { get; set; }

        public string UnderlyingCategory { get; set; }

        public string SubCategory { get; set; }

        public string Code { get; set; }

        public string Currency               { get; set; }
        public string SerialNumber           { get; set; }
        public string DeliveryType           { get; set; }
        public string CommodityType          { get; set; }
        public string Fineness               { get; set; }
        public string Weight                 { get; set; }
        public string SettlementPolicyMethod { get; set; }
    }
}