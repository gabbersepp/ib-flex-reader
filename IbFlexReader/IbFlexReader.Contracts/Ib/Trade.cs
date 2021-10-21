using System.Globalization;

namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;
    using IbFlexReader.Contracts.Enums;

    public class Trade
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

        public long? TradeID { get; set; }

        public PutCall? PutCall { get; set; }

        //Note: The reportDate XML attribute may contain either a date or a string, i.e. reportDate="MULTI"
        public string ReportDate { get; set; }

        public string PrincipalAdjustFactor { get; set; }

        [Format(Constants.DateTimeFormat, 0)]
        // alternative format
        [Format(Constants.DateFormat, 1)]
        public DateTime? TradeDateTime { get; set; }

        //Note: The tradeDate XML attribute may contain either a date or a string, i.e. tradeDate="MULTI"
        public string TradeDate { get; set; }

        public string TradeTime { get; set; }

        public DateTime? TradeDateTime2
        {
            get
            {
                try
                {
                    DateTime dt        = DateTime.ParseExact($"{TradeDate}:{TradeTime}", "yyyyMMdd:HHmmss", CultureInfo.InvariantCulture);
                    return dt;
                }
                catch (Exception)
                {
                    // ignored
                }

                return null;
            }
        }

        //Note: The settleDateTarget XML attribute may contain either a date or a string, i.e. settleDateTarget="MULTI"
        public string SettleDateTarget { get; set; }

        public string TransactionType { get; set; }

        public string Exchange { get; set; }

        public double? Quantity { get; set; }

        public double? TradePrice { get; set; }

        public double? TradeMoney { get; set; }

        public double? Proceeds { get; set; }

        public double? Taxes { get; set; }

        public double? IbCommission { get; set; }

        public Currencies? IbCommissionCurrency { get; set; }

        public double? NetCash { get; set; }

        public double? ClosePrice { get; set; }

        public OpenClose? OpenCloseIndicator { get; set; }

        public Notes? Notes { get; set; }

        public double? Cost { get; set; }

        public double? FifoPnlRealized { get; set; }

        public double? FxPnl { get; set; }

        public double? MtmPnl { get; set; }

        public double? OrigTradePrice { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? OrigTradeDate { get; set; }

        public long? OrigTradeID { get; set; }

        public long? OrigOrderID { get; set; }

        public string ClearingFirmID { get; set; }

        public string TransactionID { get; set; }

        public BuySell? BuySell { get; set; }

        public long? IbOrderID { get; set; }

        public string IbExecID { get; set; }

        public string BrokerageOrderID { get; set; }

        public string OrderReference { get; set; }

        public string VolatilityOrderLink { get; set; }

        public string ExchOrderId { get; set; }

        public string ExtExecID { get; set; }

        [Format(Constants.DateTimeFormat)]
        public DateTime? OrderTime { get; set; }

        [Format(Constants.DateTimeFormat)]
        public DateTime? OpenDateTime { get; set; }

        [Format(Constants.DateTimeFormat)]
        public DateTime? HoldingPeriodDateTime { get; set; }

        [Format(Constants.DateTimeFormat)]
        public DateTime? WhenRealized { get; set; }

        [Format(Constants.DateTimeFormat)]
        public DateTime? WhenReopened { get; set; }

        public string LevelOfDetail { get; set; }

        public double? ChangeInPrice { get; set; }

        public double? ChangeInQuantity { get; set; }

        public string OrderType { get; set; }

        public string IsAPIOrder { get; set; }

        public double? AccruedInterest { get; set; }

        public string TraderID { get; set; }

        public string SerialNumber  { get; set; }
        public string DeliveryType  { get; set; }
        public string CommodityType { get; set; }
        public string Fineness      { get; set; }
        public string Weight        { get; set; }
    }
}