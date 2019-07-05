namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "OpenDividendAccrual")]
    public class OpenDividendAccrual
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

        [XmlAttribute(AttributeName = "exDate")]
        public string ExDate { get; set; }

        [XmlAttribute(AttributeName = "payDate")]
        public string PayDate { get; set; }

        [XmlAttribute(AttributeName = "quantity")]
        public string Quantity { get; set; }

        [XmlAttribute(AttributeName = "tax")]
        public string Tax { get; set; }

        [XmlAttribute(AttributeName = "fee")]
        public string Fee { get; set; }

        [XmlAttribute(AttributeName = "grossRate")]
        public string GrossRate { get; set; }

        [XmlAttribute(AttributeName = "grossAmount")]
        public string GrossAmount { get; set; }

        [XmlAttribute(AttributeName = "netAmount")]
        public string NetAmount { get; set; }

        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }

        [XmlAttribute(AttributeName = "fromAcct")]
        public string FromAcct { get; set; }

        [XmlAttribute(AttributeName = "toAcct")]
        public string ToAcct { get; set; }
    }
}