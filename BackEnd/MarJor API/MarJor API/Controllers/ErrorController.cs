using Microsoft.AspNetCore.Mvc;

[ApiController]
public class ErrorController : ControllerBase
{
    [Route("/error")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public IActionResult Error()
    {
        var context = HttpContext.Features.Get<Microsoft.AspNetCore.Diagnostics.IExceptionHandlerFeature>();
        var exception = context?.Error;

        var problemDetails = new ProblemDetails
        {
            Status = 500,
            Title = "An error occurred while processing your request.",
            Detail = exception?.Message
        };

        return StatusCode(500, problemDetails);
    }
}