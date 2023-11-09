namespace Domain.Models.Result
{
    public class GetHostInfoResult
    {
        public int HostID { get; set; }
        public string HostName { get; set; }
        public string HostDesc { get; set; }
        public string HostCode { get; set; }
        public int SvcTypeID { get; set; }
        public string SvcType { get; set; }
        public int SignBy { get; set; }
        public string PaymentTemplate { get; set; }
        public string? SecondEntryTemplate { get; set; }
        public string? MesgTemplate { get; set; }
        public int NeedReplyAcknowledgement { get; set; }
        public int NeedRedirectOTP { get; set; }
        public int Require2ndEntry { get; set; }
        public int AllowQuery { get; set; }
        public int AllowReversal { get; set; }
        public string CountryName { get; set; }
        public int ChannelID { get; set; }
        public int Timeout { get; set; }
        public int ChannelTimeout { get; set; }
        public int IsActive { get; set; }
        public int TxnStatusActionID { get; set; }
        public int HostReplyMethod { get; set; }
        public string OSPymtCode { get; set; }
        public int GatewayTxnIDFormat { get; set; }
        public int SettlePeriod { get; set; }
        public DateTime DateActivated { get; set; }
        public DateTime DateDeactivated { get; set; }
        public string Desc { get; set; }
        public string PayURL { get; set; }
        public string CfgFile { get; set; }
        public string? ReturnURL { get; set; }
        public string? ReturnURL2 { get; set; }
        public string? ReturnIPAddresses { get; set; }
        public string Protocol { get; set; }
        public string? MerchantPassword { get; set; }
        public string? ReturnKey { get; set; }
        public string? HashMethod { get; set; }
        public int QueryFlag { get; set; }
        public string? SecretKey { get; set; }
        public string? InitVector { get; set; }
        public int LogRes { get; set; }
        public string? QueryURL { get; set; }
        public string? SelectedCurrExpnt { get; set; }
        public string PymtMethod { get; set; }
        public int onCVV { get; set; }
        public int HostMPI { get; set; }
        public int HostSupport3DS { get; set; }
        public int RefundType { get; set; }
        public string ClientID { get; set; }
        public string AccessKey { get; set; }
        public string SecurityKey { get; set; }
        public string EncryptionKey { get; set; }
        public string? ExtraURL { get; set; }
        public string InitAuthenticationURL { get; set; }
        public int CaptureType { get; set; }
        public int ReversalTimeout { get; set; }
        public string LogoPath { get; set; }
        public int Tokenization { get; set; }
        public string apiUrl { get; set; }
    }
}
