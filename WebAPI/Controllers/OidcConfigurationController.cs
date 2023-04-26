using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]
public class OidcConfigurationController : Controller
{
    private readonly ILogger<OidcConfigurationController> _logger;
    public IClientRequestParametersProvider ClientRequestParametersProvider { get; }

    public OidcConfigurationController(
        IClientRequestParametersProvider requestParametersProvider,
        ILogger<OidcConfigurationController> logger)
    {
        ClientRequestParametersProvider = requestParametersProvider;
        _logger = logger;
    }

    [HttpGet("_configuration/{clientID}")]
    public IActionResult GetClientRequestParameters([FromRoute] string clientId)
    {
        var parameters = ClientRequestParametersProvider.GetClientParameters(HttpContext, clientId);
        return Ok(parameters);
    }
}
