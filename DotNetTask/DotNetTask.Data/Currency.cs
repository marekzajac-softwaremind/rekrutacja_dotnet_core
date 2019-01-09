using System;

namespace DotNetTask.Data
{
    public class Currency
    {
        public int Id { get; }
        public string Code { get; }
        public string Name { get; }

        private Currency(int id, string code, string name)
        {
            Id = id;
            Code = code;
            Name = name;
        }

        public static Currency Create(int id, string code, string name)
        {
            if (id == default(int)) throw new ArgumentException();
            if (string.IsNullOrEmpty(code)) throw new ArgumentNullException();
            if (code.Length > 4) throw new ArgumentException();
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException();

            return new Currency(id, code, name);
        }
    }
}