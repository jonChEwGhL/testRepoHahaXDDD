using Domain.Models.Global;

namespace Domain.Models.Response
{
    public class GetKEKCompleteResponse
    {
        public STPayInfo st_PayInfo { get; set; }
        public string KEK { get; set; }
        public bool bReturn { get; set; }
    }
}
