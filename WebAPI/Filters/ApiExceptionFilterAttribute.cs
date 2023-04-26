using Microsoft.AspNetCore.Mvc.Filters;

namespace WebAPI.Filters;

public class ApiExceptionFilterAttribute: ExceptionFilterAttribute
{
    private readonly IDictionary<Type, Action<ExceptionContext>> _exceptionHandler;

    public ApiExceptionFilterAttribute()
    {
        _exceptionHandler = new Dictionary<Type, Action<ExceptionContext>>
        {

        };
    }
}

