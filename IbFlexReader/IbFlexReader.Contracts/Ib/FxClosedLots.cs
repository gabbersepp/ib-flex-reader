namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public class FxClosedLots
    {
        public List<FxClosedLot> FxClosedLot { get; set; }
    }
}