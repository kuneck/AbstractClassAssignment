using System;

namespace AbstractClassAssignment
{
    //Create an abstract class called Person
    public abstract class Person
    {
        //Properties for first name and last name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Abstract method to be implemented by derived classes
        public abstract void SayName();
    }
}
