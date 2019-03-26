using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Containerized.App.Web.Api.Controllers
{
  [Route("api/health")]
  [ApiController]
  public class HealthController : ControllerBase
  {
    [HttpGet]
    public ActionResult<IEnumerable<string>> Ping()
    {
      return Ok("Okay");
    }
  }
}