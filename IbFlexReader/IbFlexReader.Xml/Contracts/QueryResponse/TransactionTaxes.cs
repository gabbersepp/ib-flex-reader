namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "TransactionTaxes")]
    public class TransactionTaxes
    {
        [XmlElement(ElementName = "TransactionTax")]
        public List<TransactionTax> TransactionTax { get; set; }
    }
}
