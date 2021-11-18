using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ruap_lv2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class contactController : ControllerBase
    {
        public string[] Get()
        {
            return new string[]
            {
        "Hello",
        "World"
            };
        }
    }
}
