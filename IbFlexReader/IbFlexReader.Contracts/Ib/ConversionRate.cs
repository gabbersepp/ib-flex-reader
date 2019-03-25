namespace IbFlexReader.Contracts
{
    public class ConversionRate
    {
        public string ReportDate { get; set; }

        public string FromCurrency { get; set; }

        public string ToCurrency { get; set; }

        public string Rate { get; set; }
    }
}