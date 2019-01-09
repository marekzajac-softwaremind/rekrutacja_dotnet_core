using DotNetTask.Api.Infrastructure;
using DotNetTask.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetTask.Api.Account
{
    public class CreateAccountCommand : ICommand
    {
        public string OwnerFirstName { get; }
        public string OwnerLastName { get; }
        public string CurrencyCode { get; }

        public CreateAccountCommand(string firstName, string lastName, string code)
        {
            OwnerFirstName = firstName;
            OwnerLastName = lastName;
            CurrencyCode = code;
        }
    }

    public class CreateAccountCommandHandler : ICommandHandler<CreateAccountCommand>
    {
        private readonly Repository _repository;

        public CreateAccountCommandHandler(Repository repository)
        {
            _repository = repository;
        }

        public void Handle(CreateAccountCommand command)
        {
            var currency = _repository.Currencies.Single(x => x.Code == command.CurrencyCode);

            _repository.AddAccount(command.OwnerFirstName, command.OwnerLastName, currency);
        }
    }
}
