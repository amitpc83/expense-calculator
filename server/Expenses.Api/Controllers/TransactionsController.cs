using Expenses.Api.Dtos;
using Expenses.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Expenses.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController(ITransactionService transactionService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var transactions = await transactionService.GetAll();
            return Ok(transactions);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var transaction = await transactionService.Get(id);
            if (transaction == null)
            {
                return NotFound();
            }
            return Ok(transaction);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateTransactionDto payload)
        {
            var transaction = await transactionService.Create(payload);
            return Ok(transaction);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id,PutTransactionDto payload)
        {
            var transaction = await transactionService.Update(id, payload);
            if(transaction == null)
            {
                return NotFound();
            }
            return Ok(transaction);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var transaction = await transactionService.Get(id);
            if(transaction == null)
            {

                return NotFound();
            }
            await transactionService.Delete(id);
            return Ok();
        }
    }
}
