using System;

namespace DotNetTask.Data
{
    public class Account
    {
        public int Id { get; }
        public string Number { get; }
        public Owner Owner { get; }
        public decimal Balance { get; private set; }
        public Currency Currency { get; }

        private Account(int id, Owner owner, Currency currency)
        {
            Id = id;
            Owner = owner;
            Currency = currency;

            Number = string.Format("{0:D10}", Id);
            Balance = 0.0m;
        }

        public static Account Create(int id, Owner owner, Currency currency)
        {
            if (id == default(int)) throw new ArgumentException();
            if (owner == null) throw new ArgumentNullException();
            if (currency == null) throw new ArgumentNullException();

            return new Account(id, owner, currency);
        }
    }
}