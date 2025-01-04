using System;

namespace Object_Oriented_Programming
{
    class Animal : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }

        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }
}
