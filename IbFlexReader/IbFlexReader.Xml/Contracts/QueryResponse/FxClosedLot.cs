namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "FxClosedLot")]
    public class FxClosedLot
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

        [XmlAttribute(AttributeName = "activityDescription")]
        public string ActivityDescription { get; set; }

        [XmlAttribute(AttributeName = "dateTime")]
        public string DateTime { get; set; }

        [XmlAttribute(AttributeName = "quantity")]
        public string Quantity { get; set; }

        [XmlAttribute(AttributeName = "proceeds")]
        public string Proceeds { get; set; }

        [XmlAttribute(AttributeName = "cost")]
        public string Cost { get; set; }

        [XmlAttribute(AttributeName = "realizedPL")]
        public string RealizedPL { get; set; }

        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }

        [XmlAttribute(AttributeName = "levelOfDetail")]
        public string LevelOfDetail { get; set; }
    }
}