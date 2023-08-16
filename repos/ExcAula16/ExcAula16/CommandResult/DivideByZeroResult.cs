using Microsoft.AspNetCore.Mvc;

namespace ExcAula16.CommandResult
{
    public class DivideByZeroResult : ObjectResult
    {
        public DivideByZeroResult(object? value) : base(value)
        {
            StatusCode = 500;
        }
    }
}
