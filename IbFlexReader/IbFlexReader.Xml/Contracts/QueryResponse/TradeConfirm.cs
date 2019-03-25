namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "TradeConfirm")]
    public class TradeConfirm
    {
        [XmlAttribute(AttributeName = "accountId")]
        public string AccountId { get; set; }

        [XmlAttribute(AttributeName = "acctAlias")]
        public string AcctAlias { get; set; }

        [XmlAttribute(AttributeName = "model")]
        public string Model { get; set; }

        [XmlAttribute(AttributeName = "currency")]
        public string Currency { get; set; }

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

        [XmlAttribute(AttributeName = "tradeID")]
        public string TradeID { get; set; }

        [XmlAttribute(AttributeName = "putCall")]
        public string PutCall { get; set; }

        [XmlAttribute(AttributeName = "reportDate")]
        public string ReportDate { get; set; }

        [XmlAttribute(AttributeName = "settleDate")]
        public string SettleDate { get; set; }

        [XmlAttribute(AttributeName = "tradeDate")]
        public string TradeDate { get; set; }

        [XmlAttribute(AttributeName = "principalAdjustFactor")]
        public string PrincipalAdjustFactor { get; set; }

        [XmlAttribute(AttributeName = "dateTime")]
        public string DateTime { get; set; }

        [XmlAttribute(AttributeName = "transactionType")]
        public string TransactionType { get; set; }

        [XmlAttribute(AttributeName = "exchange")]
        public string Exchange { get; set; }

        [XmlAttribute(AttributeName = "quantity")]
        public string Quantity { get; set; }

        [XmlAttribute(AttributeName = "proceeds")]
        public string Proceeds { get; set; }

        [XmlAttribute(AttributeName = "tax")]
        public string Tax { get; set; }

        [XmlAttribute(AttributeName = "commission")]
        public string Commission { get; set; }

        [XmlAttribute(AttributeName = "commissionCurrency")]
        public string CommissionCurrency { get; set; }

        [XmlAttribute(AttributeName = "price")]
        public string Price { get; set; }

        [XmlAttribute(AttributeName = "amount")]
        public string Amount { get; set; }

        [XmlAttribute(AttributeName = "origTradePrice")]
        public string OrigTradePrice { get; set; }

        [XmlAttribute(AttributeName = "origTradeDate")]
        public string OrigTradeDate { get; set; }

        [XmlAttribute(AttributeName = "origTradeID")]
        public string OrigTradeID { get; set; }

        [XmlAttribute(AttributeName = "clearingFirmID")]
        public string ClearingFirmID { get; set; }

        [XmlAttribute(AttributeName = "buySell")]
        public string BuySell { get; set; }

        [XmlAttribute(AttributeName = "orderID")]
        public string OrderID { get; set; }

        [XmlAttribute(AttributeName = "execID")]
        public string ExecID { get; set; }

        [XmlAttribute(AttributeName = "brokerageOrderID")]
        public string BrokerageOrderID { get; set; }

        [XmlAttribute(AttributeName = "orderReference")]
        public string OrderReference { get; set; }

        [XmlAttribute(AttributeName = "volatilityOrderLink")]
        public string VolatilityOrderLink { get; set; }

        [XmlAttribute(AttributeName = "orderTime")]
        public string OrderTime { get; set; }

        [XmlAttribute(AttributeName = "levelOfDetail")]
        public string LevelOfDetail { get; set; }

        [XmlAttribute(AttributeName = "orderType")]
        public string OrderType { get; set; }

        [XmlAttribute(AttributeName = "traderID")]
        public string TraderID { get; set; }

        [XmlAttribute(AttributeName = "isAPIOrder")]
        public string IsAPIOrder { get; set; }

        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }

        [XmlAttribute(AttributeName = "brokerExecutionCommission")]
        public string BrokerExecutionCommission { get; set; }

        [XmlAttribute(AttributeName = "brokerClearingCommission")]
        public string BrokerClearingCommission { get; set; }

        [XmlAttribute(AttributeName = "thirdPartyExecutionCommission")]
        public string ThirdPartyExecutionCommission { get; set; }

        [XmlAttribute(AttributeName = "thirdPartyClearingCommission")]
        public string ThirdPartyClearingCommission { get; set; }

        [XmlAttribute(AttributeName = "thirdPartyRegulatoryCommission")]
        public string ThirdPartyRegulatoryCommission { get; set; }

        [XmlAttribute(AttributeName = "otherCommission")]
        public string OtherCommission { get; set; }

        [XmlAttribute(AttributeName = "allocatedTo")]
        public string AllocatedTo { get; set; }
    }
}