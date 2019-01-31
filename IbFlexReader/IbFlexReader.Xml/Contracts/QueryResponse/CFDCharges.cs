using System.Collections.Generic;
using System.Xml.Serialization;

namespace IbFlexReader.Xml.Contracts
{
    [XmlRoot(ElementName = "CFDCharges")]
    public class CFDCharges
    {
        [XmlElement(ElementName = "CFDCharge")]
        public List<CFDCharge> CFDCharge { get; set; }
    }
}