namespace IbFlexReader.Xml.Contracts
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "ConversionRates")]
    public class ConversionRates
    {
        [XmlElement(ElementName = "ConversionRate")]
        public List<ConversionRate> ConversionRate { get; set; }
    }
}