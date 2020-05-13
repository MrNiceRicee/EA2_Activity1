using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public bool isNew { get; set; }
        public int Year { get; set; }

        public Car(string make, string model, decimal price, bool isNew, int year)
        {
            Make = make;
            Model = model;
            Price = price;
            this.isNew = isNew;
            Year = year;

        }

        public Car()
        {
            Make = "nothing";
            Model = "nothing";
            Price = 0;
            isNew = false;
            Year = 1900;
        }

        public String Display
        {
            get
            {
                String newStatus = "No";
                if (isNew)
                {
                    newStatus = "Yes";
                }
                return String.Format("Company: {0}           \tModel: {1} \n  Year: {2} \tNew: {3} \tPrice: {4}\n", Make, Model, Year, newStatus ,Price.ToString("C"));
            }
        }
    }
}
