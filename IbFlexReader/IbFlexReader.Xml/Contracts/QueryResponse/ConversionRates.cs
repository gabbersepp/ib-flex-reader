using System.Collections.Generic;
using System.Xml.Serialization;

namespace IbFlexReader.Xml.Contracts
{
    [XmlRoot(ElementName = "ConversionRates")]
    public class ConversionRates
    {
        [XmlElement(ElementName = "ConversionRate")]
        public List<ConversionRate> ConversionRate { get; set; }
    }
}