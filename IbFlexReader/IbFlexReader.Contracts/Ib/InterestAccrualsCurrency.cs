namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;

    public class InterestAccrualsCurrency
    {
        [Format(Constants.DateFormat)]
        public DateTime? ToDate { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? FromDate { get; set; }

        public string AccountId { get; set; }

        public string AcctAlias { get; set; }

        public string Model { get; set; }

        //Note: IB does not use a standard currency code here.  It is a value like BASE_SUMMARY.
        public string Currency { get; set; }

        public double? EndingAccrualBalance { get; set; }

        public double? FxTranslation { get; set; }

        public double? AccrualReversal { get; set; }

        public double? InterestAccrued { get; set; }

        public double? StartingAccrualBalance { get; set; }
    }
}
