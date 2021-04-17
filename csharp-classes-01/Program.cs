using System;

namespace csharp_classes_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CarWithStandardFunctionality();
            // CarWithFirstOptionalExtra();
            // CarWithConstructor();
            // CarWithObjectInitialiser();

            Console.WriteLine("Press Enter key to exit...");
            Console.ReadLine();
        }

        private static void CarWithStandardFunctionality()
        {
            Car carOne = new Car();
            carOne.Make = "Mazda";
            carOne.Model = "CX-3";
            carOne.Colour = "blue";
            carOne.Price = 28000;

            Car carTwo = new Car();
            carTwo.Make = "Toyota";
            carTwo.Model = "Kluger";
            carTwo.Colour = "yellow";
            carTwo.Price = 35000;

            Car carThree = new Car();
            carThree.Make = "Ford";
            carThree.Model = "Fiesta";
            carThree.Colour = "red";
            carThree.Price = 8000;

            Console.WriteLine($"The car is a {carOne.Colour} {carOne.Make} {carOne.Model} and costs {carOne.Price:C}");
            Console.WriteLine($"The car is a {carTwo.Colour} {carTwo.Make} {carTwo.Model} and costs {carTwo.Price:C}");
            Console.WriteLine($"The car is a {carThree.Colour} {carThree.Make} {carThree.Model} and costs {carThree.Price:C}");

        }
        private static void CarUsingMethodInsideClassForInformation()
        {
            // order of assigning values to properties do not matter
            Car carOne = new Car();
            carOne.Make = "Mazda";
            carOne.Model = "CX-3";
            carOne.Colour = "blue";
            carOne.Price = 28000;

            Car carTwo = new Car();
            carTwo.Price = 35000;
            carTwo.Make = "Toyota";
            carTwo.Model = "Kluger";
            carTwo.Colour = "yellow";

            Car carThree = new Car();
            carThree.Colour = "red";
            carThree.Make = "Ford";
            carThree.Model = "Fiesta";
            carThree.Price = 8000;

            Console.WriteLine(carOne.GetInformation());
            Console.WriteLine(carTwo.GetInformation());
            Console.WriteLine(carThree.GetInformation());

        }
        private static void CarWithConstructor()
        {
            // order of passing values into constructor MATTERS 
            // this also forces all "required" values to be set in order to constituate a "valid" instance
            // using object initialisers or setting property values manually does NOT enforce this
            Car carOne = new Car("Mazda", "CX-3", "blue", 28000);

            // if only one parameter name is specified then order MATTERS
            Car carThree = new Car("Ford", model: "Fiesta", "red", 8000);

            // specifying names of constructor parameters allows for the order to NOT matter
            Car carTwo = new Car(colour: "yellow", make: "Toyota", price: 35000, model: "Kluger");

            // the "new" expression can be simplified by not using the 'Car' class name after the new keyword
            // the type of variable already defines that and the compiler can figure out what you are trying to do
            Car carFour = new("Subaru", "Imrezza", "White", 19900);

            // the following is not allowed as ALL constructor parameters are required
            // Car carFive = new Car(colour: "yellow", price: 35000, model: "Kluger");

            Console.WriteLine(carOne.GetInformation());
            Console.WriteLine(carTwo.GetInformation());
            Console.WriteLine(carThree.GetInformation());
            Console.WriteLine(carFour.GetInformation());
        }
        private static void CarWithObjectInitialiser()
        {
            // order of property names do NOT matter when using object initialisers  
            Car carOne = new Car
            {
                Make = "Mazda", 
                Model = "CX-3", 
                Colour = "blue", 
                Price = 28000
            };

            // you can still use the constructor as well
            Car carTwo = new Car("Toyota", "Kluger", "yellow", 35000);
            
            // and 
            Car carThree = new Car
            {
                Model = "Fiesta",
                Colour = "red",
                Price = 8000
            };
            carThree.Make = "Ford";

            Console.WriteLine(carOne.GetInformation());
            Console.WriteLine(carTwo.GetInformation());
            Console.WriteLine(carThree.GetInformation());
        }
    }

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// Empty constructor is required if we want to use object initialiser or
        /// setting the properties manually AFTER the instance is created
        /// </summary>
        public Car()
        {
        }

        /// <summary>
        /// Constructor that takes all the fields required to make a proper Car instance
        /// </summary>
        public Car(string make, string model, string colour, decimal price)
        {
            Make = make;
            Model = model;
            Colour = colour;
            Price = price;
        }

        public string GetInformation()
        {
            return $"The car is a {Colour} {Make} {Model} and costs {Price:C}";
        }
    }
}
