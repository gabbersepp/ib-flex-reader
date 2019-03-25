namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;

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
}