namespace Domain.Models.Result
{
    public class GetTerminalResult
    {
        public int TerminalID { get; set; }
        public string SendKey { get; set; }
        public string ReturnKey { get; set; }
        public string SendKeyPath { get; set; }
        public string ReturnKeyPath { get; set; }
        public string SecretKey { get; set; }
        public string InitVector { get; set; }
        public string PayeeCode { get; set; }
        public string MID { get; set; }
        public string TID { get; set; }
        public string AcquirerID { get; set; }
        public string AirlineCode { get; set; }
        public int? ECIAlert { get; set; }
        public string PayURL { get; set; }
        public string ReturnURL { get; set; }
        public string ReturnURL2 { get; set; }
        public string QueryURL { get; set; }
        public string CancelURL { get; set; }
        public string ReversalURL { get; set; }
        public string ExtraURL { get; set; }
        public int PayPort { get; set; }
        public int QueryPort { get; set; }
        public int CancelPort { get; set; }
        public int ReversalPort { get; set; }
        public int ExtraPort { get; set; }
        public string CfgFile { get; set; }
        public int TimeOut { get; set; }
        public string ReturnIPAddresses { get; set; }
        public string? FXCurrencyCode { get; set; }
        public int MerchantHostTimeout { get; set; }
        public string InitAuthenticationURL { get; set; }
        public string AuthenticatePayerURL { get; set; }
        public string Protocol { get; set; }
        public int TxnStatusActionID { get; set; }
        public int GroupID { get; set; }
        public string? Param1 { get; set; }
        public string? Param2 { get; set; }
    }
}
