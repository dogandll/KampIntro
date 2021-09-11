using System;

namespace ReferansTypeSample
{
    class Program
    {
        static void Main(string[] args)
        {
        

            Customer customer1 = new Customer();
            customer1.FirstName = "Doğan";

            Employee employee = new Employee() { FirstName = "Uğur" };

            Person person1 = new Person();
            person1.FirstName ="Yusuf";

            Person person2 = customer1;
            

            PersonManager personManager = new PersonManager();
            personManager.Add(customer1);

        }

        public class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }
            public string Phone { get; set; }
        }
        public class Employee : Person
        {
            public string Job { get; set; }
        }
        public class Customer : Person
        {
            public bool IsActive { get; set; }
        }

        public class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine("Eklendi" + person.FirstName);
            }
        }
    }
}


