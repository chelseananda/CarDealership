using CarDealership.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MemoController : ControllerBase
    {
        private IRepository memoRepository;
        public MemoController(IRepository repository)
        {
            memoRepository = repository;
        }

        [HttpGet] //main route -- http://localhost:8000/api/Reservation
        public IEnumerable<Memo> Get() => memoRepository.Memos;

        //http://localhost:8000/api/Reservation/1
        [HttpGet("{id}")]
        public ActionResult<Memo> Get(int id)
        {
            if (id == 0)
            {
                return BadRequest("Value must be passed in the request body");
            }

            return Ok(memoRepository[id]);
        }

        [HttpPost]
        public Memo Post([FromBody] Memo reservationPost) =>
            memoRepository.AddMemo(
                new Memo 
                {
                    InvoiceID = reservationPost.InvoiceID,
                    CustomerName = reservationPost.CustomerName,
                    CarSerial = reservationPost.CarSerial,
                    PurchaseDate = reservationPost.PurchaseDate,
                    NetPrice = reservationPost.NetPrice,
                    OtherFees = reservationPost.OtherFees,
                    EmployeeID = reservationPost.EmployeeID
                }
                );

        [HttpPut]
        public Memo Put([FromForm] Memo reservationPut) =>
            memoRepository.UpdateMemo(reservationPut);

        [HttpDelete("{id}")]
        public void Delete(int id) => memoRepository.DeleteMemo(id);

        [HttpPatch("{id}")]
        public StatusCodeResult Patch(int id, [FromBody] JsonPatchDocument<Memo> patch)
        {
            var res = (Memo)((OkObjectResult)Get(id).Result).Value;
            if (res != null)
            {
                patch.ApplyTo(res);
                return Ok();
            }
            return NotFound();
        }

    }
}
