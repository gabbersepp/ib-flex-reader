namespace IbFlexReader.Contracts.Enums
{
    using EnumParser;

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
        PriceAdjustments,
        [EnumName("Deposits/Withdrawals")]
        DepositsWithdrawals
    }
}