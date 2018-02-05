using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBonus17_Cars
{
    class CarApp
    {
        static void Main(string[] args)
        {
            string NumberOfCars;
          
            Console.Write("Welcome to Grand Circus Motors Inventory System!\n" +
                "How many vehicles would you like to add? ");

            NumberOfCars = Console.ReadLine();
            while (Validator.CheckNumberOfCars(NumberOfCars) == false)
            {
                Console.WriteLine("Please enter a valid number of vehicles.");
                NumberOfCars = Console.ReadLine();
            }

            Car[] Inventory = new Car[int.Parse(NumberOfCars)];

            for (int i = 0; i < Inventory.Length; i++)
            {
                Inventory[i] = new Car();

                Console.Write($"Vehicle [{i + 1}] make: ");
                string MakeInput = Console.ReadLine();
                while (Validator.CheckBlankInput(MakeInput) == false)
                {
                    Console.WriteLine("Please enter a valid make.");
                    MakeInput = Console.ReadLine();
                }
                Inventory[i].Make = MakeInput;

                Console.Write($"Vehicle [{i + 1}] model: ");
                string ModelInput = Console.ReadLine();
                while(Validator.CheckBlankInput(ModelInput) == false)
                {
                    Console.WriteLine("Please enter a valid model.");
                    ModelInput = Console.ReadLine();
                }
                Inventory[i].Model = ModelInput;

                Console.Write($"Vehicle [{i + 1}] model year: ");
                string YearInput = Console.ReadLine();
                while(Validator.CheckYear(YearInput) == false)
                {
                    Console.WriteLine("Not a valid model year. Please try again.");
                    YearInput = Console.ReadLine();
                }
                Inventory[i].Year = int.Parse(YearInput);

                Console.Write($"Vehicle [{i + 1}] price: ");
                string PriceInput = Console.ReadLine();
                while (Validator.CheckPrice(PriceInput) == false)
                {
                    Console.WriteLine("Please enter a valid price.");
                    PriceInput = Console.ReadLine();
                }
                Inventory[i].Price = double.Parse(PriceInput);
            }

            Console.WriteLine(new string('*',50));
            Console.WriteLine("VEHICLES IN INVENTORY:");
            Console.WriteLine(new string('*', 50));
            Console.WriteLine($"{"MAKE",-10}{"MODEL",-10}{"YEAR",-10}{"MSRP",-10}");
            Console.WriteLine($"{new string('-',6),-10}{new string('-', 6),-10}{new string('-', 6),-10}{new string('-', 6),-10}");

            foreach (Car c in Inventory)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}
