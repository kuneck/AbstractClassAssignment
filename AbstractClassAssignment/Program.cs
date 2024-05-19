using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an Employee object with firstName and lastName
            Employee employee = new Employee
            {
                FirstName = "James",
                LastName = "Bond"
            };

            //Call the SayName method on the object
            employee.SayName();

            //Keep console open
            Console.ReadLine();
        }
    }
}
