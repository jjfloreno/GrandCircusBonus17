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
            //validate input

            Car[] Inventory = new Car[int.Parse(NumberOfCars)];

            for (int i = 0; i < Inventory.Length; i++)
            {
                Inventory[i] = new Car();

                Console.Write($"Vehicle [{i + 1}] make: ");
                //validate input
                Inventory[i].Make = Console.ReadLine();

                Console.Write($"Vehicle [{i + 1}] model: ");
                //validate input
                Inventory[i].Model = Console.ReadLine();

                Console.Write($"Vehicle [{i + 1}] model year: ");
                //validate year
                Inventory[i].Year = int.Parse(Console.ReadLine());

                Console.Write($"Vehicle [{i + 1}] price: ");
                //validate price
                Inventory[i].Price = double.Parse(Console.ReadLine());
            }

            Console.WriteLine(new string('*',50));
            Console.WriteLine("VEHICLES IN INVENTORY:");
            Console.WriteLine(new string('*', 50));
            Console.WriteLine($"{"MAKE",-10}{"MODEL",-10}{"YEAR",-10}{"MSRP",-10}");
            Console.WriteLine($"{new string('-',6),-10}{new string('-', 6),-10}{new string('-', 6),-10}{new string('-', 6),-10}");

            foreach (Car c in Inventory)
            {
                Console.WriteLine($"{c.Make,-10}{c.Model,-10}{c.Year,-10}{c.Price,-10}");
            }
        }
    }
}
