namespace IbFlexReader.Contracts.Ib
{
    using System;
    using System.Xml.Serialization;

    public class FxTransaction
    {
        public string AccountId           { get; set; }
        public string AcctAlias           { get; set; }
        public string Model               { get; set; }
        public string AssetCategory       { get; set; }
        public string ReportDate          { get; set; }
        public string FunctionalCurrency  { get; set; }
        public string FxCurrency          { get; set; }
        public string ActivityDescription { get; set; }
        public string DateTime            { get; set; }
        public double? Quantity            { get; set; }
        public double? Proceeds            { get; set; }
        public double? Cost                { get; set; }
        public double? RealizedPL          { get; set; }
        public string Code                { get; set; }
        public string LevelOfDetail       { get; set; }
    }
}
