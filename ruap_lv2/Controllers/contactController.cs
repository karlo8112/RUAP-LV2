using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ruap_lv2.Models;

namespace ruap_lv2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class contactController : ControllerBase
    {
        public Contact[] Get()
        {
            return new Contact[]
            {
               new Contact
               {
                   Id = 1,
                   Name = "Glenn Block"
               },
               new Contact
               {
                   Id = 2,
                   Name = "Dan Roth"
               }
            };
        }
    }
}
