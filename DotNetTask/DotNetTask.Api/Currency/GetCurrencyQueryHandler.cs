using DotNetTask.Api.Infrastructure;
using DotNetTask.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetTask.Api.Currency
{
    public class GetCurrencyQuery : IQuery
    { }

    public class GetCurrencyQueryHandler : IQueryHandler<GetCurrencyQuery, CurrenciesDto>
    {
        private readonly Repository _repository;

        public GetCurrencyQueryHandler(Repository repository)
        {
            _repository = repository;
        }

        public CurrenciesDto Handle(GetCurrencyQuery query)
        {
            var currencies = _repository.Currencies.Select(x => x.Code);

            var dto = new CurrenciesDto
            {
                Codes = currencies
            };

            return dto;
        }
    }
}
