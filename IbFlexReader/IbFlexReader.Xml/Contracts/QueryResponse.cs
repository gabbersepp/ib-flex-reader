/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0

 https://xmltocsharp.azurewebsites.net/
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using IbFlexReader.Xml.Contracts;

namespace IbFlexReader.Xml.Contracts
{
    [XmlRoot(ElementName = "AccountInformation")]
    public class AccountInformation
    {
        [XmlAttribute(AttributeName = "accountId")]
        public string AccountId { get; set; }
        [XmlAttribute(AttributeName = "acctAlias")]
        public string AcctAlias { get; set; }
        [XmlAttribute(AttributeName = "model")]
        public string Model { get; set; }
        [XmlAttribute(AttributeName = "currency")]
        public string Currency { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "accountType")]
        public string AccountType { get; set; }
        [XmlAttribute(AttributeName = "customerType")]
        public string CustomerType { get; set; }
        [XmlAttribute(AttributeName = "accountCapabilities")]
        public string AccountCapabilities { get; set; }
        [XmlAttribute(AttributeName = "tradingPermissions")]
        public string TradingPermissions { get; set; }
        [XmlAttribute(AttributeName = "registeredRepName")]
        public string RegisteredRepName { get; set; }
        [XmlAttribute(AttributeName = "registeredRepPhone")]
        public string RegisteredRepPhone { get; set; }
        [XmlAttribute(AttributeName = "dateOpened")]
        public string DateOpened { get; set; }
        [XmlAttribute(AttributeName = "dateFunded")]
        public string DateFunded { get; set; }
        [XmlAttribute(AttributeName = "dateClosed")]
        public string DateClosed { get; set; }
        [XmlAttribute(AttributeName = "street")]
        public string Street { get; set; }
        [XmlAttribute(AttributeName = "street2")]
        public string Street2 { get; set; }
        [XmlAttribute(AttributeName = "city")]
        public string City { get; set; }
        [XmlAttribute(AttributeName = "state")]
        public string State { get; set; }
        [XmlAttribute(AttributeName = "country")]
        public string Country { get; set; }
        [XmlAttribute(AttributeName = "postalCode")]
        public string PostalCode { get; set; }
        [XmlAttribute(AttributeName = "streetResidentialAddress")]
        public string StreetResidentialAddress { get; set; }
        [XmlAttribute(AttributeName = "street2ResidentialAddress")]
        public string Street2ResidentialAddress { get; set; }
        [XmlAttribute(AttributeName = "cityResidentialAddress")]
        public string CityResidentialAddress { get; set; }
        [XmlAttribute(AttributeName = "stateResidentialAddress")]
        public string StateResidentialAddress { get; set; }
        [XmlAttribute(AttributeName = "countryResidentialAddress")]
        public string CountryResidentialAddress { get; set; }
        [XmlAttribute(AttributeName = "postalCodeResidentialAddress")]
        public string PostalCodeResidentialAddress { get; set; }
        [XmlAttribute(AttributeName = "masterName")]
        public string MasterName { get; set; }
        [XmlAttribute(AttributeName = "ibEntity")]
        public string IbEntity { get; set; }
        [XmlAttribute(AttributeName = "primaryEmail")]
        public string PrimaryEmail { get; set; }
    }

    [XmlRoot(ElementName = "EquitySummaryByReportDateInBase")]
    public class EquitySummaryByReportDateInBase
    {
        [XmlAttribute(AttributeName = "accountId")]
        public string AccountId { get; set; }
        [XmlAttribute(AttributeName = "acctAlias")]
        public string AcctAlias { get; set; }
        [XmlAttribute(AttributeName = "model")]
        public string Model { get; set; }
        [XmlAttribute(AttributeName = "reportDate")]
        public string ReportDate { get; set; }
        [XmlAttribute(AttributeName = "cash")]
        public string Cash { get; set; }
        [XmlAttribute(AttributeName = "cashLong")]
        public string CashLong { get; set; }
        [XmlAttribute(AttributeName = "cashShort")]
        public string CashShort { get; set; }
        [XmlAttribute(AttributeName = "slbCashCollateral")]
        public string SlbCashCollateral { get; set; }
        [XmlAttribute(AttributeName = "slbCashCollateralLong")]
        public string SlbCashCollateralLong { get; set; }
        [XmlAttribute(AttributeName = "slbCashCollateralShort")]
        public string SlbCashCollateralShort { get; set; }
        [XmlAttribute(AttributeName = "stock")]
        public string Stock { get; set; }
        [XmlAttribute(AttributeName = "stockLong")]
        public string StockLong { get; set; }
        [XmlAttribute(AttributeName = "stockShort")]
        public string StockShort { get; set; }
        [XmlAttribute(AttributeName = "slbDirectSecuritiesBorrowed")]
        public string SlbDirectSecuritiesBorrowed { get; set; }
        [XmlAttribute(AttributeName = "slbDirectSecuritiesBorrowedLong")]
        public string SlbDirectSecuritiesBorrowedLong { get; set; }
        [XmlAttribute(AttributeName = "slbDirectSecuritiesBorrowedShort")]
        public string SlbDirectSecuritiesBorrowedShort { get; set; }
        [XmlAttribute(AttributeName = "slbDirectSecuritiesLent")]
        public string SlbDirectSecuritiesLent { get; set; }
        [XmlAttribute(AttributeName = "slbDirectSecuritiesLentLong")]
        public string SlbDirectSecuritiesLentLong { get; set; }
        [XmlAttribute(AttributeName = "slbDirectSecuritiesLentShort")]
        public string SlbDirectSecuritiesLentShort { get; set; }
        [XmlAttribute(AttributeName = "options")]
        public string Options { get; set; }
        [XmlAttribute(AttributeName = "optionsLong")]
        public string OptionsLong { get; set; }
        [XmlAttribute(AttributeName = "optionsShort")]
        public string OptionsShort { get; set; }
        [XmlAttribute(AttributeName = "commodities")]
        public string Commodities { get; set; }
        [XmlAttribute(AttributeName = "commoditiesLong")]
        public string CommoditiesLong { get; set; }
        [XmlAttribute(AttributeName = "commoditiesShort")]
        public string CommoditiesShort { get; set; }
        [XmlAttribute(AttributeName = "bonds")]
        public string Bonds { get; set; }
        [XmlAttribute(AttributeName = "bondsLong")]
        public string BondsLong { get; set; }
        [XmlAttribute(AttributeName = "bondsShort")]
        public string BondsShort { get; set; }
        [XmlAttribute(AttributeName = "notes")]
        public string Notes { get; set; }
        [XmlAttribute(AttributeName = "notesLong")]
        public string NotesLong { get; set; }
        [XmlAttribute(AttributeName = "notesShort")]
        public string NotesShort { get; set; }
        [XmlAttribute(AttributeName = "funds")]
        public string Funds { get; set; }
        [XmlAttribute(AttributeName = "fundsLong")]
        public string FundsLong { get; set; }
        [XmlAttribute(AttributeName = "fundsShort")]
        public string FundsShort { get; set; }
        [XmlAttribute(AttributeName = "interestAccruals")]
        public string InterestAccruals { get; set; }
        [XmlAttribute(AttributeName = "interestAccrualsLong")]
        public string InterestAccrualsLong { get; set; }
        [XmlAttribute(AttributeName = "interestAccrualsShort")]
        public string InterestAccrualsShort { get; set; }
        [XmlAttribute(AttributeName = "softDollars")]
        public string SoftDollars { get; set; }
        [XmlAttribute(AttributeName = "softDollarsLong")]
        public string SoftDollarsLong { get; set; }
        [XmlAttribute(AttributeName = "softDollarsShort")]
        public string SoftDollarsShort { get; set; }
        [XmlAttribute(AttributeName = "forexCfdUnrealizedPl")]
        public string ForexCfdUnrealizedPl { get; set; }
        [XmlAttribute(AttributeName = "forexCfdUnrealizedPlLong")]
        public string ForexCfdUnrealizedPlLong { get; set; }
        [XmlAttribute(AttributeName = "forexCfdUnrealizedPlShort")]
        public string ForexCfdUnrealizedPlShort { get; set; }
        [XmlAttribute(AttributeName = "cfdUnrealizedPl")]
        public string CfdUnrealizedPl { get; set; }
        [XmlAttribute(AttributeName = "cfdUnrealizedPlLong")]
        public string CfdUnrealizedPlLong { get; set; }
        [XmlAttribute(AttributeName = "cfdUnrealizedPlShort")]
        public string CfdUnrealizedPlShort { get; set; }
        [XmlAttribute(AttributeName = "dividendAccruals")]
        public string DividendAccruals { get; set; }
        [XmlAttribute(AttributeName = "dividendAccrualsLong")]
        public string DividendAccrualsLong { get; set; }
        [XmlAttribute(AttributeName = "dividendAccrualsShort")]
        public string DividendAccrualsShort { get; set; }
        [XmlAttribute(AttributeName = "fdicInsuredBankSweepAccountCashComponent")]
        public string FdicInsuredBankSweepAccountCashComponent { get; set; }
        [XmlAttribute(AttributeName = "fdicInsuredBankSweepAccountCashComponentLong")]
        public string FdicInsuredBankSweepAccountCashComponentLong { get; set; }
        [XmlAttribute(AttributeName = "fdicInsuredBankSweepAccountCashComponentShort")]
        public string FdicInsuredBankSweepAccountCashComponentShort { get; set; }
        [XmlAttribute(AttributeName = "fdicInsuredAccountInterestAccrualsComponent")]
        public string FdicInsuredAccountInterestAccrualsComponent { get; set; }
        [XmlAttribute(AttributeName = "fdicInsuredAccountInterestAccrualsComponentLong")]
        public string FdicInsuredAccountInterestAccrualsComponentLong { get; set; }
        [XmlAttribute(AttributeName = "fdicInsuredAccountInterestAccrualsComponentShort")]
        public string FdicInsuredAccountInterestAccrualsComponentShort { get; set; }
        [XmlAttribute(AttributeName = "total")]
        public string Total { get; set; }
        [XmlAttribute(AttributeName = "totalLong")]
        public string TotalLong { get; set; }
        [XmlAttribute(AttributeName = "totalShort")]
        public string TotalShort { get; set; }
    }

    [XmlRoot(ElementName = "EquitySummaryInBase")]
    public class EquitySummaryInBase
    {
        [XmlElement(ElementName = "EquitySummaryByReportDateInBase")]
        public List<EquitySummaryByReportDateInBase> EquitySummaryByReportDateInBase { get; set; }
    }

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

    [XmlRoot(ElementName = "OpenPositions")]
    public class OpenPositions
    {
        [XmlElement(ElementName = "OpenPosition")]
        public List<OpenPosition> OpenPosition { get; set; }
    }

    [XmlRoot(ElementName = "Trade")]
    public class Trade
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
        [XmlAttribute(AttributeName = "tradeDate")]
        public string TradeDate { get; set; }
        [XmlAttribute(AttributeName = "tradeTime")]
        public string TradeTime { get; set; }
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
        [XmlAttribute(AttributeName = "transactionID")]
        public string TransactionID { get; set; }
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
    }

    [XmlRoot(ElementName = "Trades")]
    public class Trades
    {
        [XmlElement(ElementName = "Trade")]
        public List<Trade> Trade { get; set; }
    }

    [XmlRoot(ElementName = "OptionEAE")]
    public class OptionEAE
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
        [XmlAttribute(AttributeName = "date")]
        public string Date { get; set; }
        [XmlAttribute(AttributeName = "transactionType")]
        public string TransactionType { get; set; }
        [XmlAttribute(AttributeName = "quantity")]
        public string Quantity { get; set; }
        [XmlAttribute(AttributeName = "tradePrice")]
        public string TradePrice { get; set; }
        [XmlAttribute(AttributeName = "markPrice")]
        public string MarkPrice { get; set; }
        [XmlAttribute(AttributeName = "proceeds")]
        public string Proceeds { get; set; }
        [XmlAttribute(AttributeName = "commisionsAndTax")]
        public string CommisionsAndTax { get; set; }
        [XmlAttribute(AttributeName = "costBasis")]
        public string CostBasis { get; set; }
        [XmlAttribute(AttributeName = "realizedPnl")]
        public string RealizedPnl { get; set; }
        [XmlAttribute(AttributeName = "fxPnl")]
        public string FxPnl { get; set; }
        [XmlAttribute(AttributeName = "mtmPnl")]
        public string MtmPnl { get; set; }
        [XmlAttribute(AttributeName = "tradeID")]
        public string TradeID { get; set; }
    }

    [XmlRoot(ElementName = "PriorPeriodPosition")]
    public class PriorPeriodPosition
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
        [XmlAttribute(AttributeName = "date")]
        public string Date { get; set; }
        [XmlAttribute(AttributeName = "price")]
        public string Price { get; set; }
        [XmlAttribute(AttributeName = "priorMtmPnl")]
        public string PriorMtmPnl { get; set; }
    }

    [XmlRoot(ElementName = "PriorPeriodPositions")]
    public class PriorPeriodPositions
    {
        [XmlElement(ElementName = "PriorPeriodPosition")]
        public List<PriorPeriodPosition> PriorPeriodPosition { get; set; }
    }

    [XmlRoot(ElementName = "CashTransaction")]
    public class CashTransaction
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
        [XmlAttribute(AttributeName = "dateTime")]
        public string DateTime { get; set; }
        [XmlAttribute(AttributeName = "amount")]
        public string Amount { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "tradeID")]
        public string TradeID { get; set; }
        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }
        [XmlAttribute(AttributeName = "transactionID")]
        public string TransactionID { get; set; }
        [XmlAttribute(AttributeName = "reportDate")]
        public string ReportDate { get; set; }
        [XmlAttribute(AttributeName = "clientReference")]
        public string ClientReference { get; set; }
    }

    [XmlRoot(ElementName = "CashTransactions")]
    public class CashTransactions
    {
        [XmlElement(ElementName = "CashTransaction")]
        public List<CashTransaction> CashTransaction { get; set; }
    }

    [XmlRoot(ElementName = "CFDCharge")]
    public class CFDCharge
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
        [XmlAttribute(AttributeName = "date")]
        public string Date { get; set; }
        [XmlAttribute(AttributeName = "received")]
        public string Received { get; set; }
        [XmlAttribute(AttributeName = "paid")]
        public string Paid { get; set; }
        [XmlAttribute(AttributeName = "total")]
        public string Total { get; set; }
        [XmlAttribute(AttributeName = "transactionID")]
        public string TransactionID { get; set; }
    }

    [XmlRoot(ElementName = "CFDCharges")]
    public class CFDCharges
    {
        [XmlElement(ElementName = "CFDCharge")]
        public List<CFDCharge> CFDCharge { get; set; }
    }

    [XmlRoot(ElementName = "ChangeInDividendAccrual")]
    public class ChangeInDividendAccrual
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
        [XmlAttribute(AttributeName = "date")]
        public string Date { get; set; }
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

    [XmlRoot(ElementName = "ChangeInDividendAccruals")]
    public class ChangeInDividendAccruals
    {
        [XmlElement(ElementName = "ChangeInDividendAccrual")]
        public List<ChangeInDividendAccrual> ChangeInDividendAccrual { get; set; }
    }

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

    [XmlRoot(ElementName = "OpenDividendAccruals")]
    public class OpenDividendAccruals
    {
        [XmlElement(ElementName = "OpenDividendAccrual")]
        public OpenDividendAccrual OpenDividendAccrual { get; set; }
    }

    [XmlRoot(ElementName = "SecurityInfo")]
    public class SecurityInfo
    {
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
        [XmlAttribute(AttributeName = "maturity")]
        public string Maturity { get; set; }
        [XmlAttribute(AttributeName = "issueDate")]
        public string IssueDate { get; set; }
        [XmlAttribute(AttributeName = "underlyingCategory")]
        public string UnderlyingCategory { get; set; }
        [XmlAttribute(AttributeName = "subCategory")]
        public string SubCategory { get; set; }
        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }
    }

    [XmlRoot(ElementName = "SecuritiesInfo")]
    public class SecuritiesInfo
    {
        [XmlElement(ElementName = "SecurityInfo")]
        public List<SecurityInfo> SecurityInfo { get; set; }
    }

    [XmlRoot(ElementName = "ConversionRate")]
    public class ConversionRate
    {
        [XmlAttribute(AttributeName = "reportDate")]
        public string ReportDate { get; set; }
        [XmlAttribute(AttributeName = "fromCurrency")]
        public string FromCurrency { get; set; }
        [XmlAttribute(AttributeName = "toCurrency")]
        public string ToCurrency { get; set; }
        [XmlAttribute(AttributeName = "rate")]
        public string Rate { get; set; }
    }

    [XmlRoot(ElementName = "ConversionRates")]
    public class ConversionRates
    {
        [XmlElement(ElementName = "ConversionRate")]
        public List<ConversionRate> ConversionRate { get; set; }
    }

    [XmlRoot(ElementName = "FlexStatement")]
    public class FlexStatement
    {
        [XmlElement(ElementName = "AccountInformation")]
        public AccountInformation AccountInformation { get; set; }
        [XmlElement(ElementName = "EquitySummaryInBase")]
        public EquitySummaryInBase EquitySummaryInBase { get; set; }
        [XmlElement(ElementName = "OpenPositions")]
        public OpenPositions OpenPositions { get; set; }
        [XmlElement(ElementName = "Trades")]
        public Trades Trades { get; set; }
        [XmlElement(ElementName = "TransactionTaxes")]
        public string TransactionTaxes { get; set; }
        [XmlElement(ElementName = "OptionEAE")]
        public OptionEAE OptionEAE { get; set; }
        [XmlElement(ElementName = "PriorPeriodPositions")]
        public PriorPeriodPositions PriorPeriodPositions { get; set; }
        [XmlElement(ElementName = "CorporateActions")]
        public string CorporateActions { get; set; }
        [XmlElement(ElementName = "CashTransactions")]
        public CashTransactions CashTransactions { get; set; }
        [XmlElement(ElementName = "CFDCharges")]
        public CFDCharges CFDCharges { get; set; }
        [XmlElement(ElementName = "Transfers")]
        public string Transfers { get; set; }
        [XmlElement(ElementName = "ChangeInDividendAccruals")]
        public ChangeInDividendAccruals ChangeInDividendAccruals { get; set; }
        [XmlElement(ElementName = "OpenDividendAccruals")]
        public OpenDividendAccruals OpenDividendAccruals { get; set; }
        [XmlElement(ElementName = "SecuritiesInfo")]
        public SecuritiesInfo SecuritiesInfo { get; set; }
        [XmlElement(ElementName = "ConversionRates")]
        public ConversionRates ConversionRates { get; set; }
        [XmlAttribute(AttributeName = "accountId")]
        public string AccountId { get; set; }
        [XmlAttribute(AttributeName = "fromDate")]
        public string FromDate { get; set; }
        [XmlAttribute(AttributeName = "toDate")]
        public string ToDate { get; set; }
        [XmlAttribute(AttributeName = "period")]
        public string Period { get; set; }
        [XmlAttribute(AttributeName = "whenGenerated")]
        public string WhenGenerated { get; set; }
    }

    [XmlRoot(ElementName = "FlexStatements")]
    public class FlexStatements
    {
        [XmlElement(ElementName = "FlexStatement")]
        public FlexStatement FlexStatement { get; set; }
        [XmlAttribute(AttributeName = "count")]
        public string Count { get; set; }
    }

    [XmlRoot(ElementName = "FlexQueryResponse")]
    public class FlexQueryResponse : XmlBase
    {
        [XmlElement(ElementName = "FlexStatements")]
        public FlexStatements FlexStatements { get; set; }
        [XmlAttribute(AttributeName = "queryName")]
        public string QueryName { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }

}
