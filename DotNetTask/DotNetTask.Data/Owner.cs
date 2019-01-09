using System;

namespace DotNetTask.Data
{
    public class Owner
    {
        public string FirstName { get; }
        public string LastName { get; }

        private Owner(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public static Owner Create(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName)) throw new ArgumentNullException();
            if (string.IsNullOrEmpty(lastName)) throw new ArgumentNullException();

            return new Owner(firstName, lastName);
        }
    }
}