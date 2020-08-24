namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "Transfers")]
    public class Transfers
    {
        [XmlElement(ElementName = "Transfer")]
        public List<Transfer> Transfer { get; set; }
    }
}
