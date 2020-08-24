namespace IbFlexReader.Contracts
{
    using System.Collections.Generic;
    using IbFlexReader.Contracts.Ib;

    public class FlexStatements
    {
        public List<FlexStatement> FlexStatement { get; set; }

        public int? Count { get; set; }
    }
}