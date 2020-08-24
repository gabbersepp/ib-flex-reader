namespace IbFlexReader.Contracts.Enums
{
    using EnumParser;

    [EnumName]
    public enum BuySell
    {
        [EnumName("BUY")]
        BUY,
        [EnumName("SELL")]
        SELL,
        [EnumName("SELL (Ca.)")]
        SELLCa 
    }
}