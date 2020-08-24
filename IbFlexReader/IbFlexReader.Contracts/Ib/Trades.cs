namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    public class Trades
    {
        public List<Lot> Lot { get; set; }
        public List<Trade> Trade { get; set; }
        public List<AssetSummary> AssetSummary { get; set; }
        public List<SymbolSummary> SymbolSummary { get; set; }
        public List<Order> Order { get; set; }
    }
}