using System.Collections.Generic;
using System.Xml.Serialization;

namespace IbFlexReader.Xml.Contracts
{
    [XmlRoot(ElementName = "ChangeInDividendAccruals")]
    public class ChangeInDividendAccruals
    {
        [XmlElement(ElementName = "ChangeInDividendAccrual")]
        public List<ChangeInDividendAccrual> ChangeInDividendAccrual { get; set; }
    }
}