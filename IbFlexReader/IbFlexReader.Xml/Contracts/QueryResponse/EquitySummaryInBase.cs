using System.Collections.Generic;
using System.Xml.Serialization;

namespace IbFlexReader.Xml.Contracts
{
    [XmlRoot(ElementName = "EquitySummaryInBase")]
    public class EquitySummaryInBase
    {
        [XmlElement(ElementName = "EquitySummaryByReportDateInBase")]
        public List<EquitySummaryByReportDateInBase> EquitySummaryByReportDateInBase { get; set; }
    }
}