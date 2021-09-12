using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, FirstName = "Doğan", LastName = "Dellal", City = "İstanbul" };

            Customer customer1 = new Customer(2, "Uğur", "Dellal", "İstanbul");

            Console.WriteLine(customer1.FirstName);
        }
    }

    class Customer
    {
        public Customer()
        {
            Console.WriteLine("Constructor çalıştı.");
        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
