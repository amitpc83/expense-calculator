using Expenses.Api.Data;
using Expenses.Api.Dtos;
using Expenses.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Expenses.Api.Services
{
    public class TransactionService(ApplicationDbContext context) : ITransactionService
    {
        public async Task<Transaction> Create(CreateTransactionDto transaction)
        {
            var newTransaction = new Transaction();

            newTransaction.Amount = transaction.Amount;
            newTransaction.Category = transaction.Category;
            newTransaction.Type = transaction.Type;            
            newTransaction.CreatedAt = DateTime.UtcNow;
            newTransaction.UpdatedAt = DateTime.UtcNow;

            await context.Transactions.AddAsync(newTransaction);
            await context.SaveChangesAsync();
            return newTransaction;

        }

        public async Task Delete(int id)
        {
            var transaction = await context.Transactions.FindAsync(id);
            if (transaction != null)
            {
                context.Transactions.Remove(transaction);
                await context.SaveChangesAsync();
            }
        }

        public async Task<Transaction?> Get(int id)
        {
            var transaction = await context.Transactions.FindAsync(id);
            return transaction;
        }

        public async Task<IEnumerable<Transaction>> GetAll()
        {
            return await context.Transactions.ToListAsync();
        }

        public async Task<Transaction?> Update(int id, PutTransactionDto transaction)
        {
            var existingTransaction = await context.Transactions.FindAsync(id);
            if (existingTransaction != null)
            {
                existingTransaction.Type = transaction.Type;
                existingTransaction.Category = transaction.Category;
                existingTransaction.Amount = transaction.Amount;
                existingTransaction.UpdatedAt = DateTime.UtcNow;
                await context.SaveChangesAsync();
            }
            return existingTransaction;
        }
    }
}
