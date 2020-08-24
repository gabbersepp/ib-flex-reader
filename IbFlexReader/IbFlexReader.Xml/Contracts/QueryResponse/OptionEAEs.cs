namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    //IB does not pluralize the containing OptionEAE in the FlexStatement
    [XmlRoot(ElementName = "OptionEAE")]
    public class OptionEAEs
    {
        [XmlElement(ElementName = "OptionEAE")]
        public List<OptionEAE> OptionEAE { get; set; }
    }
}