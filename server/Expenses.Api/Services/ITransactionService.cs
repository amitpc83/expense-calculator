using Expenses.Api.Dtos;
using Expenses.Api.Models;

namespace Expenses.Api.Services
{
    public interface ITransactionService
    {
        Task<IEnumerable<Transaction>> GetAll();
        Task<Transaction?> Get(int id);
        Task<Transaction?> Update(int id,PutTransactionDto transaction);
        Task Delete(int id);
        Task<Transaction> Create(CreateTransactionDto transaction);
    }
}
