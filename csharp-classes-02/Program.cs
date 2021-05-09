using System;

namespace csharp_classes_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Flash");
            Dog dog = new Dog("Buzz");
            Cat cat = new Cat("Snowflake");

            Console.WriteLine(animal.Greet());
            Console.Write(dog.Greet());
            Console.WriteLine(dog.Bark());
            Console.WriteLine(cat.Greet());

            Console.WriteLine("Press Enter key to exit...");
            Console.ReadLine();
        }
   

    public class Animal
    {
        private string _name;

        /// <summary>
        /// Constructor that takes all the fields required to make a proper Car instance
        /// </summary>
        public Animal(string name)
        {
            _name = name;
        }

        public virtual string Greet()
        {
            return $"Hi, my name is {_name}";
        }
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override string Greet()
        {
            return $"{base.Greet()}.  I am a dog. ";
        }

        public string Bark()
        {
            return "Woof, woof!!";
        }
    }

    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override string Greet()
        {
            return $"{base.Greet()}.  I am a cat.";
        }
    }
}
