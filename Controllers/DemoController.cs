using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        [MapToApiVersion("1.0")]
        public string GetV1() => "Version 1.0";

        [HttpGet]
        [MapToApiVersion("2.0")]
        public string GetV2() => "Version 2.0";
    }
}