using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ruap_lv2.Models;
using ruap_lv2.Services;

namespace ruap_lv2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class contactController : ControllerBase
    {
        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        }

        private ContactRepository contactRepository;

        public contactController()
        {
            this.contactRepository = new ContactRepository();
        }

    }
}
