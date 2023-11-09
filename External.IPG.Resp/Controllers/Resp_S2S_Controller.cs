
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using External.IPG.Resp;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


namespace Internal.TNGD.Controllers
{
    public class Resp_S2S_Controller : ApiController
    {
        private readonly ILogger<Resp_S2S_Controller> _logger;

        public Resp_S2S_Controller(ILogger<Resp_S2S_Controller> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PBB3_S2S()
        {
            string authCode = HttpContext.Request.Query["authCode"].ToString() ?? "";
            string authState = HttpContext.Request.Query["authSign"].ToString() ?? "";
            if (authCode.IsNullOrEmpty() || authState.IsNullOrEmpty() || gatewaytxnid.IsNullOrEmpty())
            {
                throw new Exception($"The authCode or authState for {gatewaytxnid} is null or empty");
            }

            _logger.LogInformation("Log PBB3_S2S:- " + JsonSerializer.Serialize(""));

            try
            {
                var result = await Mediator.Send(command);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error bGetHostInfo:- {ex}");
                throw ex;
            }
        }
    }
}
