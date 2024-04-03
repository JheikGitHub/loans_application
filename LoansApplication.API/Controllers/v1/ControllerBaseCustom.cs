using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace LoansApplication.API.Controllers.v1
{
    [Route("v1/api/")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiController]
    public abstract class ControllerBaseCustom : ControllerBase
    {
    }
}
