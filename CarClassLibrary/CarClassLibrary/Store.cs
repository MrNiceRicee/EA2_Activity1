using System;
using CarClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Store
    {




        public List<Car> CarList { get; set; }
        public List<Car> ShoppingList { get; set; }

        public Store()
        {
            CarList = new List<Car>();
            ShoppingList = new List<Car>(0);
        }

        public decimal checkout()
        {
            decimal totalCost = 0;

            foreach (var c in ShoppingList)
            {
                totalCost += c.Price;
            }

            ShoppingList.Clear();

            return totalCost;
        }


        //Strings for random cars
        private String[] Make = {"Toyota", "Honda", "Nissan", "Ford", "Tesla", "BMW", "Volkswagen" };

        //most common models for the makes
        private String[] Toyota = { "Corolla", "Camry", "Prius", "Highlander", "RAV4", "Avalon" };
        private String[] Honda = {"Accord", "Odyssey", "Civic", "Civic Type R", "Pilot", "CR-V", "Fit", "S2000" };
        private String[] Nissan = {"Altima", "Maxima" , "Rogue" , "Versa", "Sentra", "Pathfinder", "Skyline GTR", "Skyline R32", "Skyline R33", "Skyline R34" };
        private String[] Ford = {"Fusion", "F-150", "Escape" ,  "Explorer" , "Mustang" , "Fiesta" };
        private String[] Tesla = {"Model S", "Model 3", "Model X", "Model Y", "Roadster", "Roadster 2.0" };
        private String[] BMW = { "3 Series", "X3", "M3", "X5", "7 Series", "5 Series", "6 Series" };
        private String[] Volkswagen = {"Jetta", "Beetle", "Golf", "Atlas", "Passat", "Tiguan"  };

        public string getModel(String make)
        {
            string r = "Model";
            Random random = new Random();
            if (make.Equals("Toyota"))
            {
                r = Toyota[random.Next(0, Toyota.Length)];
            }else if (make.Equals("Honda"))
            {
                r = Honda[random.Next(0, Honda.Length)];
            }
            else if (make.Equals("Nissan"))
            {
                r = Nissan[random.Next(0, Nissan.Length)];
            }
            else if (make.Equals("Ford"))
            {
                r = Ford[random.Next(0, Ford.Length)];
            }
            else if (make.Equals("Tesla"))
            {
                r = Tesla[random.Next(0, Tesla.Length)];
            }
            else if (make.Equals("BMW"))
            {
                r = BMW[random.Next(0, BMW.Length)];
            }
            else if (make.Equals("Volkswagen"))
            {
                r = Volkswagen[random.Next(0, Volkswagen.Length)];
            }
            return r;
        }

        public List<Car> generatedCars(int amount)
        {
            List<Car> r = new List<Car>();
            Random random = new Random();
            int max = 50000;
            int min = 5000;
            for (int i = 0; i < amount; i++)
            {
                String rMake = Make[random.Next(0,Make.Length)];
                String rModel = getModel(rMake);
                decimal rPrice = Convert.ToDecimal((random.Next(1,10)*10000) +(random.Next(1,3)*5000)+ ((random.Next(1,3)*500)-1));
                //100,000+ 5,000 + (499/999) + 0.95;

                bool rNew = false;
                int rYear = random.Next(1990,2021);
                int check = random.Next(1, 100);
                if (check%2 == 0)
                {
                    rNew = true;
                    rYear = 2021;
                    // makes sure its new, both the year and also status

                }
                
                if (rNew is false)
                {
                    rPrice /= 2;
                    rPrice -= .5m;
                    // if its not new the price gets changed
                }
                Decimal.Round(rPrice, 2, MidpointRounding.AwayFromZero);
                rPrice += 0.95m;

                //Console.WriteLine(rPrice.ToString("C"));
                //get a random double first, convert it to a decimal, then clean it up by only having 2 decimal places
                Car gCar = new Car();
                gCar.Make = rMake;
                gCar.Model = rModel;
                gCar.Price = rPrice;
                gCar.isNew = rNew;
                gCar.Year = rYear;
                r.Add(gCar);
            }
            return r;
        }
    }
}
