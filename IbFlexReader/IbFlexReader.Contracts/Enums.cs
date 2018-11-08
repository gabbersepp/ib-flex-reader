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

    public class EnumParser
    {
        public static object ParseWithMapping(Type type, string name)
        {
            var attr = type.GetCustomAttributes(false).OfType<EnumNameAttribute>().FirstOrDefault();

            if (attr != null)
            {
                var field = type.GetFields()
                    .Select(f => new { FieldName = f.Name, Ca = f.GetCustomAttributes(typeof(EnumNameAttribute), false).OfType<EnumNameAttribute>().FirstOrDefault()?.Value })
                    .FirstOrDefault(x => x.Ca == name);

                if (field == null)
                {
                    return null;
                }

                return Enum.Parse(type, field.FieldName);
            }

            return null;
        }

        public static object Parse(Type type, string name)
        {
            var splits = name.Split(';');

            var retVal = splits.Select(x =>
            {
                var obj = ParseWithMapping(type, x);

                if (obj == null)
                {
                    obj = Enum.Parse(type, x);
                }

                return obj;
            }).Aggregate((x, y) => EnumOr(x, y));

            return retVal;
        }

        private static object EnumOr(object enum1, object enum2)
        {
            var t1 = enum1.GetType();
            var t2 = enum2.GetType();

            if (t1 != t2)
            {
                throw new Exception($"both enum types are not equal: {enum1}, {enum2}");
            }

            var enumsType = enum1.GetType().GetEnumUnderlyingType();

            // cast object to int/long
            var p1 = Expression.Parameter(typeof(object), "e1");
            var convExpr1 = Expression.Convert(p1, enumsType);
            var p2 = Expression.Parameter(typeof(object), "e2");
            var convExpr2 = Expression.Convert(p2, enumsType);
            var or = Expression.Or(convExpr1, convExpr2);
            // cast int to enum type
            var toEnumConv = Expression.Convert(or, t1);

            // we now must call Expression.Lambda<Func<object, object, EnumType>>(...)
            // to do this, build method call through reflection

            var genericLambda = typeof(Expression).GetMethods().First(x => x.Name.Contains("Lambda") && x.IsGenericMethod);
            var genericFuncType = typeof(Func<,,>);
            var parameterizedFuncType = genericFuncType.MakeGenericType(typeof(object), typeof(object), t1);
            var lambdaWithParameter = genericLambda.MakeGenericMethod(parameterizedFuncType);
            var lambdaResult = lambdaWithParameter.Invoke(null, new object[] { toEnumConv, new ParameterExpression[] { p1, p2 } });

            // now call compile()
            var compileMethod = lambdaResult.GetType().GetMethods().First(x => x.Name == "Compile" && x.GetParameters().Count() == 0);
            var compileResult = compileMethod.Invoke(lambdaResult, new object[] { });

            // now call compiled function
            var retVal = compileResult.GetType().GetMethod("Invoke").Invoke(compileResult, new object[] { enum1, enum2 });
            
            return retVal;
        }
    }
}
