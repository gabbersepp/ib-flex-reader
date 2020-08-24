namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "UnbundledCommissionDetail")]
    public class UnbundledCommissionDetail
    {
        [XmlAttribute(AttributeName = "accountId")]
        public string AccountId { get; set; }

        [XmlAttribute(AttributeName = "acctAlias")]
        public string AcctAlias { get; set; }

        [XmlAttribute(AttributeName = "quantity")]
        public string Quantity { get; set; }

        [XmlAttribute(AttributeName = "principalAdjustFactor")]
        public string PrincipalAdjustFactor { get; set; }

        [XmlAttribute(AttributeName = "putCall")]
        public string PutCall { get; set; }

        [XmlAttribute(AttributeName = "issuer")]
        public string Issuer { get; set; }

        [XmlAttribute(AttributeName = "multiplier")]
        public string Multiplier { get; set; }

        [XmlAttribute(AttributeName = "strike")]
        public string Strike { get; set; }

        [XmlAttribute(AttributeName = "expiry")]
        public string Expiry { get; set; }

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

        [XmlAttribute(AttributeName = "orderReference")]
        public string OrderReference { get; set; }

        [XmlAttribute(AttributeName = "buySell")]
        public string BuySell { get; set; }

        [XmlAttribute(AttributeName = "exchange")]
        public string Exchange { get; set; }

        [XmlAttribute(AttributeName = "dateTime")]
        public string DateTime { get; set; }

        [XmlAttribute(AttributeName = "tradeID")]
        public string TradeID { get; set; }

        [XmlAttribute(AttributeName = "model")]
        public string Model { get; set; }

        [XmlAttribute(AttributeName = "currency")]
        public string Currency { get; set; }

        [XmlAttribute(AttributeName = "fxRateToBase")]
        public string FxRateToBase { get; set; }

        [XmlAttribute(AttributeName = "other")]
        public string Other { get; set; }

        [XmlAttribute(AttributeName = "regOther")]
        public string RegOther { get; set; }

        [XmlAttribute(AttributeName = "regSection31TransactionFee")]
        public string RegSection31TransactionFee { get; set; }

        [XmlAttribute(AttributeName = "regFINRATradingActivityFee")]
        public string RegFINRATradingActivityFee { get; set; }

        [XmlAttribute(AttributeName = "thirdPartyRegulatoryCharge")]
        public string ThirdPartyRegulatoryCharge { get; set; }

        [XmlAttribute(AttributeName = "thirdPartyClearingCharge")]
        public string ThirdPartyClearingCharge { get; set; }

        [XmlAttribute(AttributeName = "thirdPartyExecutionCharge")]
        public string ThirdPartyExecutionCharge { get; set; }

        [XmlAttribute(AttributeName = "brokerClearingCharge")]
        public string BrokerClearingCharge { get; set; }

        [XmlAttribute(AttributeName = "brokerExecutionCharge")]
        public string BrokerExecutionCharge { get; set; }

        [XmlAttribute(AttributeName = "totalCommission")]
        public string TotalCommission { get; set; }

        [XmlAttribute(AttributeName = "price")]
        public string Price { get; set; }
    }
}
