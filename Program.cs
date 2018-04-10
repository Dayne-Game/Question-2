using System;

namespace Car_Class_2
{

    public class Car 
    {
        public string Colour {get; set; }
        public string Make {get; set; }
        public string Gearbox {get; set; }

        public string DescribeCar()
        {
            return $"This car is a {Colour} {Make} with a {Gearbox} transmission";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           //Start the program with Clear();
           Console.Clear();
           
            Console.WriteLine("ENTER NEW CAR DETAILS BELOW");
            var user = new Car();
            Console.Write(">> Colour: ");
            user.Colour = Console.ReadLine();
            Console.Write(">> Make: ");
            user.Make = Console.ReadLine();
            Console.Write(">> Gearbox: ");
            user.Gearbox = Console.ReadLine();

            Console.WriteLine(user.DescribeCar());
           
           //End the program with blank line and instructions
           Console.ResetColor();
           Console.WriteLine();
           Console.WriteLine("Press <Enter> to quit the program");
           Console.ReadKey();
        }
    }
}
