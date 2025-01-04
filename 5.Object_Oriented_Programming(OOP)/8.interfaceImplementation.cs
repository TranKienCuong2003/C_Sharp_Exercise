using System;

namespace Object_Oriented_Programming
{
    class InterfaceImplementation
    {
        public static void Run()
        {
            IAnimal animal = new Dog();
            animal.Speak();
        }
    }
}
