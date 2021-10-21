namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public class FxTransactions
    {
        public List<FxTransaction> FxTransaction { get; set; }
        public List<FxClosedLots>  FxClosedLots  { get; set; }
    }
}
