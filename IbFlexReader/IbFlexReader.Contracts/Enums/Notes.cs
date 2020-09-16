namespace IbFlexReader.Contracts.Enums
{
    using System;
    using EnumParser;

    [EnumName]
    [Flags]
    public enum Notes : long
    {
        [EnumName("A")]
        Assigned = 1,
        [EnumName("AEx")]
        AutomaticalExercise = 1L << 1,
        [EnumName("Adj")]
        Adjustment = 1L << 2,
        [EnumName("Al")]
        Allocation = 1L << 3,
        [EnumName("Aw")]
        AwayTrade = 1L << 4,
        [EnumName("B")]
        AutoBuyIn = 1L << 5,
        [EnumName("Bo")]
        DirectLending = 1L << 6,
        [EnumName("C")]
        ClosingTrade = 1L << 7,
        [EnumName("CD")]
        CashDelivery = 1L << 8,
        [EnumName("CP")]
        ComplexePosition = 1L << 9,
        [EnumName("Ca")]
        Deleted = 1L << 10,
        [EnumName("Co")]
        CorrectedTrade = 1L << 11,
        [EnumName("Cx")]
        CrossTrade = 1L << 12,
        [EnumName("ETF")]
        EtfCreation = 1L << 13,
        [EnumName("Ep")]
        Expired = 1L << 14,
        [EnumName("Ex")]
        Exercised = 1L << 15,
        [EnumName("G")]
        GuaranteedAccountSegment = 1L << 16,
        [EnumName("HC")]
        MaxTaxBase = 1L << 17,
        [EnumName("HFI")]
        InvestmentTransferToHedgeFund = 1L << 18,
        [EnumName("HFR")]
        RedemptionForHedgeFund = 1L << 19,
        [EnumName("I")]
        InternalTransfer = 1L << 20,
        [EnumName("IA")]
        ExecutedAgainstCompany = 1L << 21,
        [EnumName("INV")]
        InvestmentTransferFromInvestor = 1L << 22,
        [EnumName("IPO")]
        IPO = 1L << 23,
        [EnumName("L")]
        MarginViolation = 1L << 24,
        [EnumName("LD")]
        AdjustedLossWashSale = 1L << 25,
        [EnumName("LI")]
        LiFo = 1L << 26,
        [EnumName("LT")]
        LongTermPL = 1L << 27,
        [EnumName("Lo")]
        DirectLoan = 1L << 28,
        [EnumName("M")]
        ManualThroughIB = 1L << 29,
        [EnumName("MEx")]
        ManualExercise = 1L << 30,
        [EnumName("ML")]
        MaximizeLoss = 1L << 31,
        [EnumName("MLG")]
        MLG = 1L << 32,
        [EnumName("MLL")]
        MLL = 1L << 33,
        [EnumName("MSG")]
        MSG = 1L << 34,
        [EnumName("MSL")]
        MSL = 1L << 35,
        [EnumName("O")]
        OpeningTrade = 1L << 36,
        [EnumName("P")]
        PartialExecution = 1L << 37,
        [EnumName("PI")]
        PI = 1L << 38,
        [EnumName("Po")]
        InterestDividendAccrualPosting = 1L << 39,
        [EnumName("Pr")]
        PrincipalTrade = 1L << 40,
        [EnumName("R")]
        DividendReinvestment = 1L << 41,
        [EnumName("RED")]
        RedemptionToInvestor = 1L << 42,
        [EnumName("Re")]
        TransformationInterestDividend = 1L << 43,
        [EnumName("Ri")]
        Refund = 1L << 44,
        [EnumName("SI")]
        ArrangedByIB = 1L << 45,
        [EnumName("SL")]
        SL = 1L << 46,
        [EnumName("SO")]
        ArrangedByIntroducingBroker = 1L << 47,
        [EnumName("SS")]
        ShortendedExecution = 1L << 48,
        [EnumName("ST")]
        ShortTermPL = 1L << 49,
        [EnumName("SY")]
        StockYieldEligible = 1L << 50,
        [EnumName("T")]
        Transfer = 1L << 51,

        [EnumName("ADR")]
        ADRFeeAccrual = 1L << 52,
        [EnumName("FP")]
        IBPrincipalForFractional = 1L << 53,
        [EnumName("FPA")]
        IBPrincipalForFractionalAgentWhole = 1L << 54,
        [EnumName("RP")]
        IBRisklessPrincipalForFractional = 1L << 55,
        [EnumName("RPA")]
        IBRisklessPrincipalForFractionalAgentWhole = 1L << 56,
        [EnumName("U")]
        UnvestedSharesFromStockGrant = 1L << 57,
        [EnumName("D")]
        Delisted = 1L << 58
    }
}