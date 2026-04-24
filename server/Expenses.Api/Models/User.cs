using Expenses.Api.Models.Base;

namespace Expenses.Api.Models
{
    public class User : BaseEntity
    {
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}
