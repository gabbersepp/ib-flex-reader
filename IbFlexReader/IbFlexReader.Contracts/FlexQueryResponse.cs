namespace IbFlexReader.Contracts
{
    using System.Collections.Generic;

    public class FlexQueryResponse
    {
        public FlexStatements FlexStatements { get; set; }

        public string QueryName { get; set; }

        public string Type { get; set; }

        public List<ErrorMessage> Errors { get; set; }
        public string MappingErrors { get; set; }
    }
}