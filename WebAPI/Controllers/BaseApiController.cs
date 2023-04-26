using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;
[ApiController]
//[ApiExceptionFilter]
[Route("api/[controller]")]
public abstract class BaseApiController : ControllerBase
{
    public ISender? _mediator;

    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();

}
