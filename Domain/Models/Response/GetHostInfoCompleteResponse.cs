using Domain.Models.Global;

namespace Domain.Models.Response
{
    public class GetHostInfoCompleteResponse
    {
        public STHost st_HostInfo { get; set; }
        public STPayInfo st_PayInfo { get; set; }
        public bool bReturn { get; set; }
    }
}
