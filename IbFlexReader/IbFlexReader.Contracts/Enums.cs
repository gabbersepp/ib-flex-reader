using EnumParser;
using IbFlexReader.Contracts.Attributes;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace IbFlexReader.Contracts
{
    public enum PutCall
    {
        P, C
    }

    public enum LongShort
    {
        Long, Short
    }

    public enum Currencies
    {
        EUR,
        USD,
        JPY,
        CHF,
        GBP,
        NZD,
        AUD,
        CAD

    }

    public enum AssetCategory
    {
        STK, OPT, FOP, CFD, FUT
    }

    [Flags]
    public enum OpenClose
    {
        O = 1, C = 2
    }

    public enum BuySell
    {
        BUY, SELL
    }

    [EnumName]
    public enum CashTransactionType
    {
        [EnumName("Other Fees")]
        OtherFees,
        [EnumName("Withholding Tax")]
        WithholdingTax,
        [EnumName("Dividends")]
        Dividends,
        [EnumName("Payment In Lieu Of Dividends")]
        PaymentInLieuOfDividends,
        [EnumName("Broker Interest Paid")]
        BrokerInterestPaid,
        [EnumName("Price Adjustments")]
        PriceAdjustments
    }
    
    [EnumName]
    public enum Notes : long
    {
        [EnumName("A")]
        Assigned = 1,
        [EnumName("AEx")]
        AutomaticalExercise = 2^1,
        [EnumName("Adj")]
        Adjustment = 2^2,
        [EnumName("Aw")]
        AwayTrade = 2^3,
        [EnumName("B")]
        AutoBuyIn = 2^4,
        [EnumName("Bo")]
        DirectLending = 2^5,
        [EnumName("CD")]
        CashDelivery = 2^6,
        [EnumName("CP")]
        ComplexePosition = 2^7,
        [EnumName("Ca")]
        Deleted = 2^8,
        [EnumName("Co")]
        CorrectedTrade = 2^9,
        [EnumName("Cx")]
        CrossTrade = 2^10,
        [EnumName("ETF")]
        EtfCreation = 2^11,
        [EnumName("Ep")]
        Expired = 2^12,
        [EnumName("Ex")]
        Exercised = 2^13,
        [EnumName("G")]
        GuaranteedAccountSegment = 2^14,
        [EnumName("HC")]
        MaxTaxBase = 2^15,
        [EnumName("HFI")]
        InvestmentTransferToHedgeFund = 2^16,
        [EnumName("HFR")]
        RedemptionForHedgeFund = 2^17,
        [EnumName("I")]
        InternalTransfer = 2^18,
        [EnumName("IA")]
        ExecutedAgainstCompany = 2^19,
        [EnumName("INV")]
        InvestmentTransferFromInvestor = 2^20,
        [EnumName("IPO")]
        IPO = 2^21,
        [EnumName("L")]
        MarginViolation = 2^22,
        [EnumName("LD")]
        AdjustedLossWashSale = 2^23,
        [EnumName("LI")]
        LiFo = 2^24,
        [EnumName("LT")]
        LongTermPL = 2^25,
        [EnumName("M")]
        ManualThroughIB = 2^26,
        [EnumName("MEx")]
        ManualExercise = 2^27,
        [EnumName("ML")]
        MaximizeLoss = 2^28,
        [EnumName("MLG")]
        MLG = 2^29,
        [EnumName("MLL")]
        MLL = 2^30,
        [EnumName("MSG")]
        MSG = 2^31,
        [EnumName("MSL")]
        MSL = 2^32,
        [EnumName("O")]
        OpeningTrade = 2^33,
        [EnumName("P")]
        PartialExecution = 2^34,
        [EnumName("PI")]
        PI = 2^35,
        [EnumName("Po")]
        InterestDividendAccrualPosting = 2^36,
        [EnumName("Pr")]
        PrincipalTrade = 2^37,
        [EnumName("R")]
        DividendReinvestment = 2^38,
        [EnumName("RED")]
        RedemptionToInvestor = 2^39,
        [EnumName("Re")]
        TransformationInterestDividend = 2^40,
        [EnumName("Ri")]
        Refund = 2^41,
        [EnumName("SI")]
        ArrangedByIB = 2^42,
        [EnumName("SL")]
        SL = 2^43,
        [EnumName("SO")]
        ArrangedByIntroducingBroker = 2^44,
        [EnumName("SS")]
        ShortendedExecution = 2^45,
        [EnumName("ST")]
        ShortTermPL = 2^46,
        [EnumName("T")]
        Transfer = 2^47
    }
}
