namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "CFDCharges")]
    public class CFDCharges
    {
        [XmlElement(ElementName = "CFDCharge")]
        public List<CFDCharge> CFDCharge { get; set; }
    }
}