using System;

namespace AbstractClassAssignment
{
    //Create class called Employee that inherits from Person
    public class Employee : Person
    {
        //Implement the SayName method from the base class
        public override void SayName()
        {
            //Output the person's full name to the console
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
