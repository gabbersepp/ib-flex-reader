using System.Xml.Serialization;

namespace IbFlexReader.Xml.Contracts
{
    [XmlRoot(ElementName = "ConversionRate")]
    public class ConversionRate
    {
        [XmlAttribute(AttributeName = "reportDate")]
        public string ReportDate { get; set; }

        [XmlAttribute(AttributeName = "fromCurrency")]
        public string FromCurrency { get; set; }

        [XmlAttribute(AttributeName = "toCurrency")]
        public string ToCurrency { get; set; }

        [XmlAttribute(AttributeName = "rate")]
        public string Rate { get; set; }
    }
}