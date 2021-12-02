using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPICourseService.Models;

namespace WebAPICourseService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VCardFormatterController : ControllerBase
    {
        [HttpGet]
        public Contact GetContact() //OutputFormatter
        {
            Contact contact = new Contact();
            contact.Id = 1;
            contact.Firstname = "Otto";
            contact.Lastname = "Walkes";

            return contact;
        }

        [HttpPost]
        public IActionResult InsertContact(Contact contact)
        {
            return Ok();
        }
    }
}
