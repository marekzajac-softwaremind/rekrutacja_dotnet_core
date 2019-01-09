using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetTask.Data
{
    public class Repository
    {
        public IList<Account> Accounts { get; private set; }
        public IList<Currency> Currencies { get; private set; }

        public Repository()
        {
            Currencies = new List<Currency>
            {
                Currency.Create(1, "USD", "Dolar amerykański"),
                Currency.Create(2, "PLN", "Polski Złoty"),
                Currency.Create(3, "EUR", "Euro")
            };

            Accounts = new List<Account>
            {
                Account.Create(1, Owner.Create("Marek", "Zając"), Currencies[1]),
                Account.Create(2, Owner.Create("Tomek", "Zając"), Currencies[1]),
                Account.Create(3, Owner.Create("Marcin", "Kowalski"), Currencies[1]),
                Account.Create(4, Owner.Create("Marek", "Zając"), Currencies[0]),
                Account.Create(5, Owner.Create("Adam", "Nowak"), Currencies[1]),
                Account.Create(6, Owner.Create("Karolina", "Wójt"), Currencies[1]),
                Account.Create(7, Owner.Create("Jan", "Kowalski"), Currencies[2]),
                Account.Create(8, Owner.Create("Marta", "Królik"), Currencies[1])
            };
        }

        public void AddAccount(string ownerFirstName, string ownerLastName, Currency currency)
        {
            var id = Accounts.Max(x => x.Id) + 1;

            Accounts.Add(Account.Create(id, Owner.Create(ownerFirstName, ownerLastName), currency));
        }

        public void AddCurrency(string code, string name)
        {
            var id = Currencies.Max(x => x.Id) + 1;

            Currencies.Add(Currency.Create(id, code, name));
        }
    }
}
