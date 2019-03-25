namespace IbFlexReader.Contracts
{
    using System;
    using System.Collections.Generic;
    using IbFlexReader.Contracts.Attributes;
    using IbFlexReader.Contracts.Enums;

    public class AccountInformation
    {
        public string AccountId { get; set; }

        public string AcctAlias { get; set; }

        public string Model { get; set; }

        public Currencies? Currency { get; set; }

        public string Name { get; set; }

        public string AccountType { get; set; }

        public string CustomerType { get; set; }

        public string AccountCapabilities { get; set; }

        public string TradingPermissions { get; set; }

        public string RegisteredRepName { get; set; }

        public string RegisteredRepPhone { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? DateOpened { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? DateFunded { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? DateClosed { get; set; }

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

        [Format(Constants.DateFormat)]
        public DateTime? ReportDate { get; set; }

        public double? Cash { get; set; }

        public double? CashLong { get; set; }

        public double? CashShort { get; set; }

        public double? SlbCashCollateral { get; set; }

        public double? SlbCashCollateralLong { get; set; }

        public double? SlbCashCollateralShort { get; set; }

        public double? Stock { get; set; }

        public double? StockLong { get; set; }

        public double? StockShort { get; set; }

        public double? SlbDirectSecuritiesBorrowed { get; set; }

        public double? SlbDirectSecuritiesBorrowedLong { get; set; }

        public double? SlbDirectSecuritiesBorrowedShort { get; set; }

        public double? SlbDirectSecuritiesLent { get; set; }

        public double? SlbDirectSecuritiesLentLong { get; set; }

        public double? SlbDirectSecuritiesLentShort { get; set; }

        public double? Options { get; set; }

        public double? OptionsLong { get; set; }

        public double? OptionsShort { get; set; }

        public double? Commodities { get; set; }

        public double? CommoditiesLong { get; set; }

        public double? CommoditiesShort { get; set; }

        public double? Bonds { get; set; }

        public double? BondsLong { get; set; }

        public double? BondsShort { get; set; }

        public double? Notes { get; set; }

        public double? NotesLong { get; set; }

        public double? NotesShort { get; set; }

        public double? Funds { get; set; }

        public double? FundsLong { get; set; }

        public double? FundsShort { get; set; }

        public double? InterestAccruals { get; set; }

        public double? InterestAccrualsLong { get; set; }

        public double? InterestAccrualsShort { get; set; }

        public double? SoftDollars { get; set; }

        public double? SoftDollarsLong { get; set; }

        public double? SoftDollarsShort { get; set; }

        public double? ForexCfdUnrealizedPl { get; set; }

        public double? ForexCfdUnrealizedPlLong { get; set; }

        public double? ForexCfdUnrealizedPlShort { get; set; }

        public double? CfdUnrealizedPl { get; set; }

        public double? CfdUnrealizedPlLong { get; set; }

        public double? CfdUnrealizedPlShort { get; set; }

        public double? DividendAccruals { get; set; }

        public double? DividendAccrualsLong { get; set; }

        public double? DividendAccrualsShort { get; set; }

        public double? FdicInsuredBankSweepAccountCashComponent { get; set; }

        public double? FdicInsuredBankSweepAccountCashComponentLong { get; set; }

        public double? FdicInsuredBankSweepAccountCashComponentShort { get; set; }

        public double? FdicInsuredAccountInterestAccrualsComponent { get; set; }

        public double? FdicInsuredAccountInterestAccrualsComponentLong { get; set; }

        public double? FdicInsuredAccountInterestAccrualsComponentShort { get; set; }

        public double? Total { get; set; }

        public double? TotalLong { get; set; }

        public double? TotalShort { get; set; }
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

        public int? UnderlyingConid { get; set; }

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

        [Format(Constants.DateFormat)]
        public DateTime? ReportDate { get; set; }

        public int? Position { get; set; }

        public double? MarkPrice { get; set; }

        public double? PositionValue { get; set; }

        public double? OpenPrice { get; set; }

        public double? CostBasisPrice { get; set; }

        public double? CostBasisMoney { get; set; }

        public string PercentOfNAV { get; set; }

        public double? FifoPnlUnrealized { get; set; }

        public LongShort? Side { get; set; }

        public string LevelOfDetail { get; set; }

        [Format(Constants.DateTimeFormat)]
        public DateTime? OpenDateTime { get; set; }

        [Format(Constants.DateTimeFormat)]
        public DateTime? HoldingPeriodDateTime { get; set; }

        public string Code { get; set; }

        public long? OriginatingOrderID { get; set; }

        public long? OriginatingTransactionID { get; set; }

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

        [Format(Constants.DateFormat)]
        public DateTime? ReportDate { get; set; }

        public string PrincipalAdjustFactor { get; set; }

        [Format(Constants.DateTimeFormat)]
        [TimeField(nameof(TradeTime))]
        public DateTime? TradeDate { get; set; }

        [Format(Constants.DateTimeFormat)]
        [DateField(nameof(TradeDate))]
        public DateTime? TradeTime { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? SettleDateTarget { get; set; }

        public string TransactionType { get; set; }

        public string Exchange { get; set; }

        public int? Quantity { get; set; }

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

        public long? TransactionID { get; set; }

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

    public class Lot : Trade
    {
    }

    public class Trades
    {
        public List<Lot> Lot { get; set; }
        public List<Trade> Trade { get; set; }
    }

    public class TradeConfirm
    {
        public string AccountId { get; set; }

        public string AcctAlias { get; set; }

        public string Model { get; set; }

        public Currencies? Currency { get; set; }

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

        [Format(Constants.DateFormat)]
        public DateTime? ReportDate { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? SettleDate { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? TradeDate { get; set; }

        public string PrincipalAdjustFactor { get; set; }

        [Format(Constants.DateTimeFormat)]
        public DateTime? DateTime { get; set; }

        public string TransactionType { get; set; }

        public string Exchange { get; set; }

        public int? Quantity { get; set; }

        public double? Proceeds { get; set; }

        public double? Tax { get; set; }

        public double? Commission { get; set; }

        public Currencies? CommissionCurrency { get; set; }

        public double? Price { get; set; }

        public double? Amount { get; set; }

        public double? OrigTradePrice { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? OrigTradeDate { get; set; }

        public long? OrigTradeID { get; set; }

        public string ClearingFirmID { get; set; }

        public BuySell? BuySell { get; set; }

        public long? OrderID { get; set; }

        public string ExecID { get; set; }

        public string BrokerageOrderID { get; set; }

        public string OrderReference { get; set; }

        public string VolatilityOrderLink { get; set; }

        public string ExchOrderId { get; set; }

        [Format(Constants.DateTimeFormat)]
        public DateTime? OrderTime { get; set; }

        public string LevelOfDetail { get; set; }

        public string OrderType { get; set; }

        public string TraderID { get; set; }

        public string IsAPIOrder { get; set; }

        public Notes? Code { get; set; }

        public double? BrokerExecutionCommission { get; set; }

        public double? BrokerClearingCommission { get; set; }

        public double? ThirdPartyExecutionCommission { get; set; }

        public double? ThirdPartyClearingCommission { get; set; }

        public double? ThirdPartyRegulatoryCommission { get; set; }

        public double? OtherCommission { get; set; }

        public string AllocatedTo { get; set; }
    }

    public class TradeConfirms
    {
        public List<TradeConfirm> TradeConfirm { get; set; }
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

        public string UnderlyingConid { get; set; }

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

        [Format(Constants.DateFormat)]
        public DateTime? DateTime { get; set; }

        public double? Amount { get; set; }

        public CashTransactionType? Type { get; set; }

        public long? TradeID { get; set; }

        public string Code { get; set; }

        public long? TransactionID { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? ReportDate { get; set; }

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
        public StmtFunds StatementOfFunds { get; set; }

        public AccountInformation AccountInformation { get; set; }

        public EquitySummaryInBase EquitySummaryInBase { get; set; }

        public OpenPositions OpenPositions { get; set; }

        public Trades Trades { get; set; }

        public TradeConfirms TradeConfirms { get; set; }

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

        [Format(Constants.DateFormat)]
        public DateTime? FromDate { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? ToDate { get; set; }

        public string Period { get; set; }

        [Format(Constants.DateTimeFormat)]
        public DateTime? WhenGenerated { get; set; }
    }

    public class FlexStatements
    {
        public FlexStatement FlexStatement { get; set; }

        public int? Count { get; set; }
    }

    public class FlexQueryResponse
    {
        public FlexStatements FlexStatements { get; set; }

        public string QueryName { get; set; }

        public string Type { get; set; }

        public List<ErrorMessage> Errors { get; set; }
    }
}
