using CarDealership.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomers customerRepository;
        

        [HttpGet] //main route -- http://localhost:8000/api/Reservation
        public IEnumerable<Customer> Get() => customerRepository.Customers;

        //http://localhost:8000/api/Reservation/1
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            if (id == 0)
            {
                return BadRequest("Value must be passed in the request body");
            }

            return Ok(customerRepository[id]);
        }

        [HttpPost]
        public Customer Post([FromBody] Customer reservationPost) =>
            customerRepository.AddCustomer(
                new Customer
                {
                    ID = reservationPost.ID,
                    Name = reservationPost.Name,
                    Email = reservationPost.Email,
                    phoneNumber = reservationPost.phoneNumber,
                }
                );

        [HttpPut]
        public Customer Put([FromForm] Customer reservationPut) =>
            customerRepository.UpdateCustomer(reservationPut);

        [HttpDelete("{id}")]
        public void Delete(int id) => customerRepository.DeleteCustomer(id);

        [HttpPatch("{id}")]
        public StatusCodeResult Patch(int id, [FromBody] JsonPatchDocument<Customer> patch)
        {
            var res = (Customer)((OkObjectResult)Get(id).Result).Value;
            if (res != null)
            {
                patch.ApplyTo(res);
                return Ok();
            }
            return NotFound();
        }

    }
}
