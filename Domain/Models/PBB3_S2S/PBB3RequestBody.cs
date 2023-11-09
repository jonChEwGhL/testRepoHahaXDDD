using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.PBB3_S2S
{
    public class PBB3RequestBody
    {
        public string GatewayTxnId { get; set; }
        public string HostTxnStatus { get; set; }
        public string AuthCode { get; set; }
        public string RespMesg {get; set; }

    }
}
