using Microsoft.AspNetCore.Mvc.Filters;

namespace MiddlewareFilters.Filters
{

    //// Utilizando ActionFilterAttribute
    //public class FiltersExample : ActionFilterAttribute
    //{
    //    private readonly ILogger<FiltersExample> _logger;

    //    public FiltersExample(ILogger<FiltersExample> logger)
    //    {
    //        _logger = logger;
    //    }

    //    public override void OnActionExecuting(ActionExecutingContext context)
    //    {
    //        //_logger.LogTrace("Log antes del método");
    //        _logger.LogInformation("Filters OnActionExecuting: Log antes del método");
    //        base.OnActionExecuting(context);
    //    }

    //    public override void OnActionExecuted(ActionExecutedContext context)
    //    {
    //        //_logger.LogTrace("Log despues del método");
    //        _logger.LogInformation("Filters OnActionExecuted: Log después del método");
    //        base.OnActionExecuted(context);
    //    }

    //}


    //// Utilizando IAsyncActionFilter
    public class FiltersExample : IAsyncActionFilter
    {
        private readonly ILogger<FiltersExample> _logger;

        public FiltersExample(ILogger<FiltersExample> logger)
        {
            _logger = logger;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            _logger.LogInformation("Filters: Log antes del método");
            await next();
            _logger.LogInformation("Filters: Log después del método");
        }
    }
}
