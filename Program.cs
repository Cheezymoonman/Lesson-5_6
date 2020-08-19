using System;

namespace Lesson_5_6
{
    class Program
    {
        public struct Customer
            {
            public string firstName;
            public string lastName;
            public int age;
            public bool hasMembership;
            }

        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();

            customer1.firstName = "Mike";
            customer1.lastName = "Smith";
            customer1.age = 17;
            customer1.hasMembership = false;

            customer2.firstName = "John";
            customer2.lastName = "White";
            customer2.age = 43;
            customer2.hasMembership = false;

            customer3.firstName = "Harold";
            customer3.lastName = "Marcus";
            customer3.age = 22;
            customer3.hasMembership = true;

            Customer[] allCustomers = { customer1, customer2, customer3 };
            for (int i = 0; i < allCustomers.Length; i++)
            {
                if (allCustomers[i].age < 21)
                {
                    Console.WriteLine(allCustomers[i].firstName + " " + allCustomers[i].lastName + " is not allowed to place an order");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].firstName + " " + allCustomers[i].lastName + " can place an order");
                }

                if (allCustomers[i].hasMembership == true)
                {
                    Console.WriteLine(allCustomers[i].firstName + " " + allCustomers[i].lastName + " is a premium member.");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].firstName + " " + allCustomers[i].lastName + " is a standard member.");
                }
            }


        }
    }
}
