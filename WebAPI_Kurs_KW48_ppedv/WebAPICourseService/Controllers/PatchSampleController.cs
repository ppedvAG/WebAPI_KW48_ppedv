using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICourseService.Models;

namespace WebAPICourseService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatchSampleController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetCustomer()
        {
            Customer customer = CreateCustomer();

            return new ObjectResult(customer);
        }

        [HttpPatch]
        //JsonPatchDocument<Customer> patchDoc -> beinhaltet die angegebene Manipulations-Operation
        public IActionResult PatchCustomer( [FromBody] JsonPatchDocument<Customer> patchDoc)
        {
            if (patchDoc != null)
            {
                //Ausgangspunkt bevor wir eine Manipulation auf unsere Customer erfolgen
                Customer customer = CreateCustomer();

                patchDoc.ApplyTo(customer, ModelState);

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                return new ObjectResult(customer);
            }
            else return BadRequest(ModelState);

        }







        private Customer CreateCustomer()
        {
            return new Customer
            {
                CustomerName = "John",
                Orders = new List<Order>()
                {
                    new Order
                    {
                        OrderName = "Order0"
                    },
                    new Order
                    {
                        OrderName = "Order1"
                    }
                }
            };
        }
    }

   
}
