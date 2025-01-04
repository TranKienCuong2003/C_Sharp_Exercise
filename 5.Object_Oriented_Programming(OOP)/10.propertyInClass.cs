using System;

namespace Object_Oriented_Programming
{
    class PropertyInClass
    {
        public static void Run()
        {
            Person person = new Person("Tran Ken Cuong", 21);
            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Age: " + person.Age);
        }
    }
}
