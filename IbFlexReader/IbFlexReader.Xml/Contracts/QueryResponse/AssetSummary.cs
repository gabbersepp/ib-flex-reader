namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "AssetSummary")]
    public class AssetSummary
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

        [XmlAttribute(AttributeName = "tradeID")]
        public string TradeID { get; set; }

        [XmlAttribute(AttributeName = "putCall")]
        public string PutCall { get; set; }

        [XmlAttribute(AttributeName = "reportDate")]
        public string ReportDate { get; set; }

        [XmlAttribute(AttributeName = "principalAdjustFactor")]
        public string PrincipalAdjustFactor { get; set; }

        [XmlAttribute(AttributeName = "dateTime")]
        public string TradeDateTime { get; set; }

        [XmlAttribute(AttributeName = "settleDateTarget")]
        public string SettleDateTarget { get; set; }

        [XmlAttribute(AttributeName = "transactionType")]
        public string TransactionType { get; set; }

        [XmlAttribute(AttributeName = "exchange")]
        public string Exchange { get; set; }

        [XmlAttribute(AttributeName = "quantity")]
        public string Quantity { get; set; }

        [XmlAttribute(AttributeName = "tradePrice")]
        public string TradePrice { get; set; }

        [XmlAttribute(AttributeName = "tradeMoney")]
        public string TradeMoney { get; set; }

        [XmlAttribute(AttributeName = "proceeds")]
        public string Proceeds { get; set; }

        [XmlAttribute(AttributeName = "taxes")]
        public string Taxes { get; set; }

        [XmlAttribute(AttributeName = "ibCommission")]
        public string IbCommission { get; set; }

        [XmlAttribute(AttributeName = "ibCommissionCurrency")]
        public string IbCommissionCurrency { get; set; }

        [XmlAttribute(AttributeName = "netCash")]
        public string NetCash { get; set; }

        [XmlAttribute(AttributeName = "closePrice")]
        public string ClosePrice { get; set; }

        [XmlAttribute(AttributeName = "openCloseIndicator")]
        public string OpenCloseIndicator { get; set; }

        [XmlAttribute(AttributeName = "notes")]
        public string Notes { get; set; }

        [XmlAttribute(AttributeName = "cost")]
        public string Cost { get; set; }

        [XmlAttribute(AttributeName = "fifoPnlRealized")]
        public string FifoPnlRealized { get; set; }

        [XmlAttribute(AttributeName = "fxPnl")]
        public string FxPnl { get; set; }

        [XmlAttribute(AttributeName = "mtmPnl")]
        public string MtmPnl { get; set; }

        [XmlAttribute(AttributeName = "origTradePrice")]
        public string OrigTradePrice { get; set; }

        [XmlAttribute(AttributeName = "origTradeDate")]
        public string OrigTradeDate { get; set; }

        [XmlAttribute(AttributeName = "origTradeID")]
        public string OrigTradeID { get; set; }

        [XmlAttribute(AttributeName = "origOrderID")]
        public string OrigOrderID { get; set; }

        [XmlAttribute(AttributeName = "clearingFirmID")]
        public string ClearingFirmID { get; set; }

        [XmlAttribute(AttributeName = "buySell")]
        public string BuySell { get; set; }

        [XmlAttribute(AttributeName = "ibOrderID")]
        public string IbOrderID { get; set; }

        [XmlAttribute(AttributeName = "ibExecID")]
        public string IbExecID { get; set; }

        [XmlAttribute(AttributeName = "brokerageOrderID")]
        public string BrokerageOrderID { get; set; }

        [XmlAttribute(AttributeName = "orderReference")]
        public string OrderReference { get; set; }

        [XmlAttribute(AttributeName = "volatilityOrderLink")]
        public string VolatilityOrderLink { get; set; }

        [XmlAttribute(AttributeName = "exchOrderId")]
        public string ExchOrderId { get; set; }

        [XmlAttribute(AttributeName = "extExecID")]
        public string ExtExecID { get; set; }

        [XmlAttribute(AttributeName = "orderTime")]
        public string OrderTime { get; set; }

        [XmlAttribute(AttributeName = "openDateTime")]
        public string OpenDateTime { get; set; }

        [XmlAttribute(AttributeName = "holdingPeriodDateTime")]
        public string HoldingPeriodDateTime { get; set; }

        [XmlAttribute(AttributeName = "whenRealized")]
        public string WhenRealized { get; set; }

        [XmlAttribute(AttributeName = "whenReopened")]
        public string WhenReopened { get; set; }

        [XmlAttribute(AttributeName = "levelOfDetail")]
        public string LevelOfDetail { get; set; }

        [XmlAttribute(AttributeName = "changeInPrice")]
        public string ChangeInPrice { get; set; }

        [XmlAttribute(AttributeName = "changeInQuantity")]
        public string ChangeInQuantity { get; set; }

        [XmlAttribute(AttributeName = "orderType")]
        public string OrderType { get; set; }

        [XmlAttribute(AttributeName = "traderID")]
        public string TraderID { get; set; }

        [XmlAttribute(AttributeName = "isAPIOrder")]
        public string IsAPIOrder { get; set; }

        [XmlAttribute(AttributeName = "accruedInt")]
        public string AccruedInterest { get; set; }

        [XmlAttribute(AttributeName = "serialNumber")]
        public string SerialNumber { get; set; }

        [XmlAttribute(AttributeName = "tradeDate")]
        public string TradeDate { get; set; }

        [XmlAttribute(AttributeName = "deliveryType")]
        public string DeliveryType { get; set; }

        [XmlAttribute(AttributeName = "commodityType")]
        public string CommodityType { get; set; }

        [XmlAttribute(AttributeName = "fineness")]
        public string Fineness { get; set; }

        [XmlAttribute(AttributeName = "weight")]
        public string Weight { get; set; }

        [XmlAttribute(AttributeName = "transactionID")]
        public string TransactionID { get; set; }
    }
}
