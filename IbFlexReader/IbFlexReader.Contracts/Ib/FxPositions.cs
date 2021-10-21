namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public class FxPositions
    {
        public List<FxPosition> FxPosition { get; set; }
        public FxLots           FxLots     { get; set; }
    }
}
