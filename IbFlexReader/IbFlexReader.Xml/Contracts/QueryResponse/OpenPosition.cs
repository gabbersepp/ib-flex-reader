namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "OpenPosition")]
    public class OpenPosition
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

        [XmlAttribute(AttributeName = "reportDate")]
        public string ReportDate { get; set; }

        [XmlAttribute(AttributeName = "position")]
        public string Position { get; set; }

        [XmlAttribute(AttributeName = "markPrice")]
        public string MarkPrice { get; set; }

        [XmlAttribute(AttributeName = "positionValue")]
        public string PositionValue { get; set; }

        [XmlAttribute(AttributeName = "openPrice")]
        public string OpenPrice { get; set; }

        [XmlAttribute(AttributeName = "costBasisPrice")]
        public string CostBasisPrice { get; set; }

        [XmlAttribute(AttributeName = "costBasisMoney")]
        public string CostBasisMoney { get; set; }

        [XmlAttribute(AttributeName = "percentOfNAV")]
        public string PercentOfNAV { get; set; }

        [XmlAttribute(AttributeName = "fifoPnlUnrealized")]
        public string FifoPnlUnrealized { get; set; }

        [XmlAttribute(AttributeName = "side")]
        public string Side { get; set; }

        [XmlAttribute(AttributeName = "levelOfDetail")]
        public string LevelOfDetail { get; set; }

        [XmlAttribute(AttributeName = "openDateTime")]
        public string OpenDateTime { get; set; }

        [XmlAttribute(AttributeName = "holdingPeriodDateTime")]
        public string HoldingPeriodDateTime { get; set; }

        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }

        [XmlAttribute(AttributeName = "originatingOrderID")]
        public string OriginatingOrderID { get; set; }

        [XmlAttribute(AttributeName = "originatingTransactionID")]
        public string OriginatingTransactionID { get; set; }

        [XmlAttribute(AttributeName = "accruedInt")]
        public string AccruedInt { get; set; }
    }
}