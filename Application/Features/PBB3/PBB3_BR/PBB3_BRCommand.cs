using Application.Common;
using Application.Interfaces;
using Domain.Models.AcquiringOrderCreate;
using Domain.Models.Global;
using Domain.Models.OAuthAccessTokenApplyNotify;
using Domain.Utilities;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Application.Features.OAuth.OAuth_AccessToken_Apply_Notify
{
    public class PBB3_BRCommand : IRequest<bool>
    {
        public string accessToken { get; set; }
        public string applyTime { get; set; }
        public string extRequestId { get; set; }
        public string extInfo { get; set; }
    }

    public class PBB3_BRCommandCommandHandler : IRequestHandler<PBB3_BRCommand, bool>
    {
        private readonly ILogger<PBB3_BRCommandCommandHandler> _logger;
        private IConfiguration _configuration;

        public PBB3_BRCommandCommandHandler(ILogger<PBB3_BRCommandCommandHandler> logger, IConfiguration configuration)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public async Task<bool> Handle(PBB3_BRCommand request, CancellationToken cancellationToken)
        {
            try
            {
                bool isResultSuccess = false;

                // check request body coming in from External TNGD Web API
                if (request is null)
                    throw new Exception("PBB3_BRCommandCommandHandler ERROR : request from External is null");

                

                return isResultSuccess;
            }
            catch (Exception ex)
            {
                _logger.LogError($"OAuthAccessTokenApplyNotifyCommandHandler ERROR : {ex.Message}");
                throw ex;
            }
        }

        public static DateTimeOffset IsUnixEpochTimestamp(string input)
        {
            if (long.TryParse(input, out long epochTime))
            {
                DateTimeOffset unixEpochStart = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);
                DateTimeOffset dateTime = unixEpochStart.AddSeconds(epochTime / 1000).ToOffset(TimeSpan.FromHours(8));
                return dateTime;
            }
            return DateTimeOffset.Now;
        }

        public static bool IsDateTimeOffset(string input)
        {
            if (DateTimeOffset.TryParse(input, out DateTimeOffset dateTimeOffset))
            {
                return true;
            }
            return false;
        }
    }
}
