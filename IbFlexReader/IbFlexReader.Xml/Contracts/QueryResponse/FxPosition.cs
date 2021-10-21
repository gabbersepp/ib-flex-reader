namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "FxPosition")]
    public class FxPosition
    {
        [XmlAttribute(AttributeName = "accountId")]
        public string AccountId { get; set; }

        [XmlAttribute(AttributeName = "acctAlias")]
        public string AcctAlias { get; set; }

        [XmlAttribute(AttributeName = "model")]
        public string Model { get; set; }

        [XmlAttribute(AttributeName = "assetCategory")]
        public string AssetCategory { get; set; }

        [XmlAttribute(AttributeName = "reportDate")]
        public string ReportDate { get; set; }

        [XmlAttribute(AttributeName = "functionalCurrency")]
        public string FunctionalCurrency { get; set; }

        [XmlAttribute(AttributeName = "fxCurrency")]
        public string FxCurrency { get; set; }

        [XmlAttribute(AttributeName = "quantity")]
        public string Quantity { get; set; }

        [XmlAttribute(AttributeName = "costPrice")]
        public string CostPrice { get; set; }

        [XmlAttribute(AttributeName = "costBasis")]
        public string CostBasis { get; set; }

        [XmlAttribute(AttributeName = "closePrice")]
        public string ClosePrice { get; set; }

        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }

        [XmlAttribute(AttributeName = "unrealizedPL")]
        public string UnrealizedPL { get; set; }

        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }

        [XmlAttribute(AttributeName = "lotDescription")]
        public string LotDescription { get; set; }

        [XmlAttribute(AttributeName = "lotOpenDateTime")]
        public string LotOpenDateTime { get; set; }

        [XmlAttribute(AttributeName = "levelOfDetail")]
        public string LevelOfDetail { get; set; }
    }
}