using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBonus17_Cars
{
    class Car
    {
        //fields
        private string make;
        private string model;
        private int year;
        private double price;

        //properties
        public string Make
        {
            set { make = value; }
            get { return make; }
        }

        public string Model
        {
            set { model = value; }
            get { return model; }
        }

        public int Year
        {
            set { year = value; }
            get { return year; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }

        //constructors
        public Car(string make, string model, int year, double price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        //method overloading (note same name as above)
        //this is creating default objects
        public Car() : this("Make Unknown", "Model Unknown", 0000, 0000)
        {

        }
    }
}
