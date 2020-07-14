namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;
    using IbFlexReader.Contracts.Enums;

    public class TierInterestDetail
    {
        public string AccountId { get; set; }

        public string AcctAlias { get; set; }

        public string Model { get; set; }

        public Currencies? Currency { get; set; }

        public double? FxRateToBase { get; set; }

        public string Code { get; set; }

        public string ToAcct { get; set; }

        public string FromAcct { get; set; }

        public double? TotalInterest { get; set; }

        public double? IbuklInterest { get; set; }

        public double? CommoditiesInterest { get; set; }

        public double? SecuritiesInterest { get; set; }

        public double? Rate { get; set; }

        public double? TotalPrincipal { get; set; }

        public double? IbuklPrincipal { get; set; }

        public double? CommoditiesPrincipal { get; set; }

        public double? SecuritiesPrincipal { get; set; }

        public double? BalanceThreshold { get; set; }

        public string TierBreak { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? ValueDate { get; set; }

        public string InterestType { get; set; }
    }
}
