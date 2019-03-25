namespace IbFlexReader.Contracts
{
    public class FlexResult
    {
        public string ErrorMessage { get; set; }
        public int? ErrorCode { get; set; }
        public string Status { get; set; }
        public bool IsSuccess => Status == "Success";
        public FlexQueryResponse FlexQueryResponse { get; set; }
        public string ReferenceCode { get; set; }
    }
}
