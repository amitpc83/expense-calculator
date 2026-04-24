namespace Expenses.Api.Dtos
{
    public class PutTransactionDto
    {
        public string Type { get; set; } = default!;
        public double Amount { get; set; }
        public string Category { get; set; } = default!;
    }
}
