namespace Expenses.Api.Dtos
{
    public class CreateTransactionDto
    {
        public string Type { get; set; } = default!;
        public double Amount { get; set; }
        public string Category { get; set; } = default!;
    }
}
