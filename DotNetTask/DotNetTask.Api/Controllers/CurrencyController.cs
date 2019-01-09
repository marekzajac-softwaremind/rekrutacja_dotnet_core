using System.Collections.Generic;
using System.Linq;
using DotNetTask.Api.Currency;
using DotNetTask.Api.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace DotNetTask.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly IQueryHandler<GetCurrencyQuery, CurrenciesDto> _getCurrencyQueryHandler;

        public CurrencyController(IQueryHandler<GetCurrencyQuery, CurrenciesDto> getCurrencyQueryHandler)
        {
            _getCurrencyQueryHandler = getCurrencyQueryHandler;
        }

        [HttpGet]
        public CurrenciesDto Get()
        {
            var query = new GetCurrencyQuery();
            var dto = _getCurrencyQueryHandler.Handle(query);
            return dto;
        }
    }
}