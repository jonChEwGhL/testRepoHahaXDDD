using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace External.IPG.Resp
{
    [ApiController]
    [Route("[controller]/[action]")]

    public abstract class ApiController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
