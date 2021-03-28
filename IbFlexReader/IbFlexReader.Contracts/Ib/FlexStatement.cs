namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;

    public class FlexStatement
    {
        public AccountInformation AccountInformation { get; set; }

        public CashTransactions CashTransactions { get; set; }

        public CFDCharges CFDCharges { get; set; }

        public ChangeInDividendAccruals ChangeInDividendAccruals { get; set; }

        public ComplexPositions ComplexPositions { get; set; }

        public ConversionRates ConversionRates { get; set; }

        public string CorporateActions { get; set; }

        public EquitySummaryInBase EquitySummaryInBase { get; set; }

        public InterestAccruals InterestAccruals { get; set; }

        public OpenDividendAccruals OpenDividendAccruals { get; set; }

        public OpenPositions OpenPositions { get; set; }

        public OptionEAEs OptionEAEs { get; set; }

        public PriorPeriodPositions PriorPeriodPositions { get; set; }

        public SecuritiesInfo SecuritiesInfo { get; set; }

        public SLBActivities SLBActivities { get; set; }

        public SLBFees SLBFees { get; set; }

        public StmtFunds StatementOfFunds { get; set; }

        public TierInterestDetails TierInterestDetails { get; set; }

        public TradeConfirms TradeConfirms { get; set; }

        public Trades Trades { get; set; }

        public TransactionTaxes TransactionTaxes { get; set; }

        public Transfers Transfers { get; set; }

        public UnbundledCommissionDetails UnbundledCommissionDetails { get; set; }

        public string AccountId { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? FromDate { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? ToDate { get; set; }

        public string Period { get; set; }

        [Format(Constants.DateTimeFormat)]
        public DateTime? WhenGenerated { get; set; }
    }
}