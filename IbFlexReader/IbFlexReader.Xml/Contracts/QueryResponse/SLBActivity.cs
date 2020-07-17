namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "SLBActivity")]
    public class SLBActivity
    {
        [XmlAttribute(AttributeName = "accountId")]
        public string AccountId { get; set; }

        [XmlAttribute(AttributeName = "acctAlias")]
        public string AcctAlias { get; set; }

        [XmlAttribute(AttributeName = "model")]
        public string Model { get; set; }

        [XmlAttribute(AttributeName = "currency")]
        public string Currency { get; set; }

        [XmlAttribute(AttributeName = "fxRateToBase")]
        public string FxRateToBase { get; set; }

        [XmlAttribute(AttributeName = "assetCategory")]
        public string AssetCategory { get; set; }

        [XmlAttribute(AttributeName = "symbol")]
        public string Symbol { get; set; }

        [XmlAttribute(AttributeName = "description")]
        public string Description { get; set; }

        [XmlAttribute(AttributeName = "conid")]
        public string Conid { get; set; }

        [XmlAttribute(AttributeName = "securityID")]
        public string SecurityID { get; set; }

        [XmlAttribute(AttributeName = "securityIDType")]
        public string SecurityIDType { get; set; }

        [XmlAttribute(AttributeName = "cusip")]
        public string Cusip { get; set; }

        [XmlAttribute(AttributeName = "isin")]
        public string Isin { get; set; }

        [XmlAttribute(AttributeName = "listingExchange")]
        public string ListingExchange { get; set; }

        [XmlAttribute(AttributeName = "underlyingConid")]
        public string UnderlyingConid { get; set; }

        [XmlAttribute(AttributeName = "underlyingSymbol")]
        public string UnderlyingSymbol { get; set; }

        [XmlAttribute(AttributeName = "underlyingSecurityID")]
        public string UnderlyingSecurityID { get; set; }

        [XmlAttribute(AttributeName = "underlyingListingExchange")]
        public string UnderlyingListingExchange { get; set; }

        [XmlAttribute(AttributeName = "issuer")]
        public string Issuer { get; set; }

        [XmlAttribute(AttributeName = "multiplier")]
        public string Multiplier { get; set; }

        [XmlAttribute(AttributeName = "strike")]
        public string Strike { get; set; }

        [XmlAttribute(AttributeName = "expiry")]
        public string Expiry { get; set; }

        [XmlAttribute(AttributeName = "putCall")]
        public string PutCall { get; set; }

        [XmlAttribute(AttributeName = "principalAdjustFactor")]
        public string PrincipalAdjustFactor { get; set; }

        [XmlAttribute(AttributeName = "exchange")]
        public string Exchange { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "date")]
        public string Date { get; set; }

        [XmlAttribute(AttributeName = "markCurrentPrice")]
        public string MarkCurrentPrice { get; set; }

        [XmlAttribute(AttributeName = "markPriorPrice")]
        public string MarkPriorPrice { get; set; }

        [XmlAttribute(AttributeName = "markQuantity")]
        public string MarkQuantity { get; set; }

        [XmlAttribute(AttributeName = "collateralAmount")]
        public string CollateralAmount { get; set; }

        [XmlAttribute(AttributeName = "activityDescription")]
        public string ActivityDescription { get; set; }

        [XmlAttribute(AttributeName = "quantity")]
        public string Quantity { get; set; }

        [XmlAttribute(AttributeName = "slbTransactionId")]
        public string SlbTransactionId { get; set; }
    }
}
