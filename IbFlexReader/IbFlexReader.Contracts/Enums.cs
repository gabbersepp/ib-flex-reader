using IbFlexReader.Contracts.Attributes;
using System;
using System.Linq;

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
        EUR, USD
    }

    public enum AssetCategory
    {
        STK, OPT, FOP, CFD, FUT
    }

    public enum OpenClose
    {
        O, C
    }

    public enum BuySell
    {
        BUY, SELL
    }

    [EnumName]
    public enum TradeType
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
        BrokerInterestPaid
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
    }
}
