namespace IbFlexReader.Xml.Contracts
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "EquitySummaryInBase")]
    public class EquitySummaryInBase
    {
        [XmlElement(ElementName = "EquitySummaryByReportDateInBase")]
        public List<EquitySummaryByReportDateInBase> EquitySummaryByReportDateInBase { get; set; }
    }
}