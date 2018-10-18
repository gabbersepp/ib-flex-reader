/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0

 https://xmltocsharp.azurewebsites.net/
 */
using IbFlexReader.Contracts.Attributes;
using System;
using System.Collections.Generic;

namespace IbFlexReader.Contracts
{

    public class AccountInformation
    {

        public string AccountId { get; set; }

        public string AcctAlias { get; set; }

        public string Model { get; set; }

        public Currencies Currency { get; set; }

        public string Name { get; set; }

        public string AccountType { get; set; }

        public string CustomerType { get; set; }

        public string AccountCapabilities { get; set; }

        public string TradingPermissions { get; set; }

        public string RegisteredRepName { get; set; }

        public string RegisteredRepPhone { get; set; }

        [Format("yyyyMMdd")]
        public DateTime DateOpened { get; set; }

        [Format("yyyyMMdd")]
        public DateTime DateFunded { get; set; }

        public string DateClosed { get; set; }

        public string Street { get; set; }

        public string Street2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string PostalCode { get; set; }

        public string StreetResidentialAddress { get; set; }

        public string Street2ResidentialAddress { get; set; }

        public string CityResidentialAddress { get; set; }

        public string StateResidentialAddress { get; set; }

        public string CountryResidentialAddress { get; set; }

        public string PostalCodeResidentialAddress { get; set; }

        public string MasterName { get; set; }

        public string IbEntity { get; set; }

        public string PrimaryEmail { get; set; }
    }


    public class EquitySummaryByReportDateInBase
    {

        public string AccountId { get; set; }

        public string AcctAlias { get; set; }

        public string Model { get; set; }

        public string ReportDate { get; set; }

        public string Cash { get; set; }

        public string CashLong { get; set; }

        public string CashShort { get; set; }

        public string SlbCashCollateral { get; set; }

        public string SlbCashCollateralLong { get; set; }

        public string SlbCashCollateralShort { get; set; }

        public string Stock { get; set; }

        public string StockLong { get; set; }

        public string StockShort { get; set; }

        public string SlbDirectSecuritiesBorrowed { get; set; }

        public string SlbDirectSecuritiesBorrowedLong { get; set; }

        public string SlbDirectSecuritiesBorrowedShort { get; set; }

        public string SlbDirectSecuritiesLent { get; set; }

        public string SlbDirectSecuritiesLentLong { get; set; }

        public string SlbDirectSecuritiesLentShort { get; set; }

        public string Options { get; set; }

        public string OptionsLong { get; set; }

        public string OptionsShort { get; set; }

        public string Commodities { get; set; }

        public string CommoditiesLong { get; set; }

        public string CommoditiesShort { get; set; }

        public string Bonds { get; set; }

        public string BondsLong { get; set; }

        public string BondsShort { get; set; }

        public string Notes { get; set; }

        public string NotesLong { get; set; }

        public string NotesShort { get; set; }

        public string Funds { get; set; }

        public string FundsLong { get; set; }

        public string FundsShort { get; set; }

        public string InterestAccruals { get; set; }

        public string InterestAccrualsLong { get; set; }

        public string InterestAccrualsShort { get; set; }

        public string SoftDollars { get; set; }

        public string SoftDollarsLong { get; set; }

        public string SoftDollarsShort { get; set; }

        public string ForexCfdUnrealizedPl { get; set; }

        public string ForexCfdUnrealizedPlLong { get; set; }

        public string ForexCfdUnrealizedPlShort { get; set; }

        public string CfdUnrealizedPl { get; set; }

        public string CfdUnrealizedPlLong { get; set; }

        public string CfdUnrealizedPlShort { get; set; }

        public string DividendAccruals { get; set; }

        public string DividendAccrualsLong { get; set; }

        public string DividendAccrualsShort { get; set; }

        public string FdicInsuredBankSweepAccountCashComponent { get; set; }

        public string FdicInsuredBankSweepAccountCashComponentLong { get; set; }

        public string FdicInsuredBankSweepAccountCashComponentShort { get; set; }

        public string FdicInsuredAccountInterestAccrualsComponent { get; set; }

        public string FdicInsuredAccountInterestAccrualsComponentLong { get; set; }

        public string FdicInsuredAccountInterestAccrualsComponentShort { get; set; }

        public string Total { get; set; }

        public string TotalLong { get; set; }

        public string TotalShort { get; set; }
    }


    public class EquitySummaryInBase
    {

        public List<EquitySummaryByReportDateInBase> EquitySummaryByReportDateInBase { get; set; }
    }


    public class OpenPosition
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

        public string ReportDate { get; set; }

        public string Position { get; set; }

        public string MarkPrice { get; set; }

        public string PositionValue { get; set; }

        public string OpenPrice { get; set; }

        public string CostBasisPrice { get; set; }

        public string CostBasisMoney { get; set; }

        public string PercentOfNAV { get; set; }

        public string FifoPnlUnrealized { get; set; }

        public string Side { get; set; }

        public string LevelOfDetail { get; set; }

        public string OpenDateTime { get; set; }

        public string HoldingPeriodDateTime { get; set; }

        public string Code { get; set; }

        public string OriginatingOrderID { get; set; }

        public string OriginatingTransactionID { get; set; }

        public string AccruedInt { get; set; }
    }


    public class OpenPositions
    {

        public List<OpenPosition> OpenPosition { get; set; }
    }


    public class Trade
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

        public string TradeID { get; set; }

        public string PutCall { get; set; }

        public string ReportDate { get; set; }

        public string PrincipalAdjustFactor { get; set; }

        public string TradeDate { get; set; }

        public string TradeTime { get; set; }

        public string SettleDateTarget { get; set; }

        public string TransactionType { get; set; }

        public string Exchange { get; set; }

        public string Quantity { get; set; }

        public string TradePrice { get; set; }

        public string TradeMoney { get; set; }

        public string Proceeds { get; set; }

        public string Taxes { get; set; }

        public string IbCommission { get; set; }

        public string IbCommissionCurrency { get; set; }

        public string NetCash { get; set; }

        public string ClosePrice { get; set; }

        public string OpenCloseIndicator { get; set; }

        public string Notes { get; set; }

        public string Cost { get; set; }

        public string FifoPnlRealized { get; set; }

        public string FxPnl { get; set; }

        public string MtmPnl { get; set; }

        public string OrigTradePrice { get; set; }

        public string OrigTradeDate { get; set; }

        public string OrigTradeID { get; set; }

        public string OrigOrderID { get; set; }

        public string ClearingFirmID { get; set; }

        public string TransactionID { get; set; }

        public string BuySell { get; set; }

        public string IbOrderID { get; set; }

        public string IbExecID { get; set; }

        public string BrokerageOrderID { get; set; }

        public string OrderReference { get; set; }

        public string VolatilityOrderLink { get; set; }

        public string ExchOrderId { get; set; }

        public string ExtExecID { get; set; }

        public string OrderTime { get; set; }

        public string OpenDateTime { get; set; }

        public string HoldingPeriodDateTime { get; set; }

        public string WhenRealized { get; set; }

        public string WhenReopened { get; set; }

        public string LevelOfDetail { get; set; }

        public string ChangeInPrice { get; set; }

        public string ChangeInQuantity { get; set; }

        public string OrderType { get; set; }

        public string TraderID { get; set; }

        public string IsAPIOrder { get; set; }
    }


    public class Trades
    {

        public List<Trade> Trade { get; set; }
    }


    public class OptionEAE
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

        public string TransactionType { get; set; }

        public string Quantity { get; set; }

        public string TradePrice { get; set; }

        public string MarkPrice { get; set; }

        public string Proceeds { get; set; }

        public string CommisionsAndTax { get; set; }

        public string CostBasis { get; set; }

        public string RealizedPnl { get; set; }

        public string FxPnl { get; set; }

        public string MtmPnl { get; set; }

        public string TradeID { get; set; }
    }


    public class PriorPeriodPosition
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

        public string Price { get; set; }

        public string PriorMtmPnl { get; set; }
    }


    public class PriorPeriodPositions
    {

        public List<PriorPeriodPosition> PriorPeriodPosition { get; set; }
    }


    public class CashTransaction
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

        public string DateTime { get; set; }

        public string Amount { get; set; }

        public string Type { get; set; }

        public string TradeID { get; set; }

        public string Code { get; set; }

        public string TransactionID { get; set; }

        public string ReportDate { get; set; }

        public string ClientReference { get; set; }
    }


    public class CashTransactions
    {

        public List<CashTransaction> CashTransaction { get; set; }
    }


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


    public class CFDCharges
    {

        public List<CFDCharge> CFDCharge { get; set; }
    }


    public class ChangeInDividendAccrual
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

        public string ReportDate { get; set; }

        public string Date { get; set; }

        public string ExDate { get; set; }

        public string PayDate { get; set; }

        public string Quantity { get; set; }

        public string Tax { get; set; }

        public string Fee { get; set; }

        public string GrossRate { get; set; }

        public string GrossAmount { get; set; }

        public string NetAmount { get; set; }

        public string Code { get; set; }

        public string FromAcct { get; set; }

        public string ToAcct { get; set; }
    }


    public class ChangeInDividendAccruals
    {

        public List<ChangeInDividendAccrual> ChangeInDividendAccrual { get; set; }
    }


    public class OpenDividendAccrual
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

        public string ExDate { get; set; }

        public string PayDate { get; set; }

        public string Quantity { get; set; }

        public string Tax { get; set; }

        public string Fee { get; set; }

        public string GrossRate { get; set; }

        public string GrossAmount { get; set; }

        public string NetAmount { get; set; }

        public string Code { get; set; }

        public string FromAcct { get; set; }

        public string ToAcct { get; set; }
    }


    public class OpenDividendAccruals
    {

        public OpenDividendAccrual OpenDividendAccrual { get; set; }
    }


    public class SecurityInfo
    {

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

        public string Maturity { get; set; }

        public string IssueDate { get; set; }

        public string UnderlyingCategory { get; set; }

        public string SubCategory { get; set; }

        public string Code { get; set; }
    }


    public class SecuritiesInfo
    {

        public List<SecurityInfo> SecurityInfo { get; set; }
    }


    public class ConversionRate
    {

        public string ReportDate { get; set; }

        public string FromCurrency { get; set; }

        public string ToCurrency { get; set; }

        public string Rate { get; set; }
    }


    public class ConversionRates
    {

        public List<ConversionRate> ConversionRate { get; set; }
    }


    public class FlexStatement
    {

        public AccountInformation AccountInformation { get; set; }

        public EquitySummaryInBase EquitySummaryInBase { get; set; }

        public OpenPositions OpenPositions { get; set; }

        public Trades Trades { get; set; }

        public string TransactionTaxes { get; set; }

        public OptionEAE OptionEAE { get; set; }

        public PriorPeriodPositions PriorPeriodPositions { get; set; }

        public string CorporateActions { get; set; }

        public CashTransactions CashTransactions { get; set; }

        public CFDCharges CFDCharges { get; set; }

        public string Transfers { get; set; }

        public ChangeInDividendAccruals ChangeInDividendAccruals { get; set; }

        public OpenDividendAccruals OpenDividendAccruals { get; set; }

        public SecuritiesInfo SecuritiesInfo { get; set; }

        public ConversionRates ConversionRates { get; set; }

        public string AccountId { get; set; }

        public string FromDate { get; set; }

        public string ToDate { get; set; }

        public string Period { get; set; }

        public string WhenGenerated { get; set; }
    }


    public class FlexStatements
    {

        public FlexStatement FlexStatement { get; set; }

        public string Count { get; set; }
    }


    public class FlexQueryResponse
    {

        public FlexStatements FlexStatements { get; set; }

        public string QueryName { get; set; }

        public string Type { get; set; }
    }

}
