namespace IbFlexReader.Contracts.Ib
{
    using System.Xml.Serialization;

    public class FxPosition
    {
        public string AccountId          { get; set; }
        public string AcctAlias          { get; set; }
        public string Model              { get; set; }
        public string AssetCategory      { get; set; }
        public string ReportDate         { get; set; }
        public string FunctionalCurrency { get; set; }
        public string FxCurrency         { get; set; }
        public double? Quantity           { get; set; }
        public double? CostPrice          { get; set; }
        public double? CostBasis          { get; set; }
        public double? ClosePrice         { get; set; }
        public double? Value              { get; set; }
        public double? UnrealizedPL       { get; set; }
        public string Code               { get; set; }
        public string LotDescription     { get; set; }
        public string LotOpenDateTime    { get; set; }
        public string LevelOfDetail      { get; set; }
    }
}
