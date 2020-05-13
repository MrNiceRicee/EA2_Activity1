using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsoleApp
{
    class Program
    {
        static Store CarStore = new Store();

        /*
         * Notes for the teacher
         * Errors:
         * Not sure how to fix it, but whenever user inputts anything, it gets written twice.
         * 
         * 
         * Things Added:
         * Cleaned up the display portion of the cars
         * Added a generator for the console app
         * Added checks if the inventory and shopping list is empty
         * Changed how the chooseaction works
         */

        static void Main(string[] args)
        {
            Console.Out.WriteLine("Hello! This is console");
            int action = -1;
            while(action != 0)
            {
                action = chooseAction(1);
                switch (action)
                {
                    case 1:
                        //User chose add car
                        Console.WriteLine("You chose to add a new car to the store:");
                        int action2 = chooseAction(2);
                        //determine if we're making manually or computer generated
                        switch (action2)
                        {
                            case 0:
                                //back to previous menu
                                break;
                            case 1:
                                //make car manually
                                Console.WriteLine("Creating Car");
                                String carMake = "";
                                String carModel = "";
                                Decimal carPrice = 0;
                                int carYear = 1990;
                                bool carNew = false;

                                Console.WriteLine("What is the car make? ex: Toyota, Nissan, Ford");
                                carMake = Console.ReadLine();

                                Console.WriteLine("What is the car model?");
                                carModel = Console.ReadLine();

                                Console.WriteLine("What is the car price?");
                                carPrice = Convert.ToDecimal(userNumber());

                                Console.WriteLine("What is the car manufactured year?");
                                carYear = Convert.ToInt16(userNumber());

                                if (carYear>2020)
                                {
                                    carNew = true;
                                }

                                Car newCar = new Car();
                                newCar.Make = carMake;
                                newCar.Model = carModel;
                                newCar.Price = carPrice;
                                newCar.Year = carYear;
                                newCar.isNew = carNew;

                                CarStore.CarList.Add(newCar);
                                printStoreInventory(CarStore);
                                break;
                            case 2:
                                //generate cars
                                int amount = Convert.ToInt16(chooseAction(3));
                                Store generated = new Store();
                                generated.CarList.AddRange(generated.generatedCars(amount));

                                //create new store object. Then generate cars to add to the carlist. Afterwards we can print out the ones we generated.
                                //this allows user to see what happened.
                                printStoreInventory(generated);
                                CarStore.CarList.AddRange(generated.CarList);


                                break;


                            default:
                                break;
                        }
                        
                        break;

                    case 2:
                        //print store inventory
                        printStoreInventory(CarStore);
                        if (CarStore.CarList.Count > 0)
                        {
                            //checks if theres anything in the list
                            int choice = 0;
                            Console.WriteLine("Which car would you like to add to the cart? (number)");
                            choice = Convert.ToInt32(userNumber());
                            try
                            {
                                CarStore.ShoppingList.Add(CarStore.CarList[choice]);

                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Not a valid input");
                                throw;
                            }
                            printShoppingCart(CarStore);
                        }else{
                            Console.WriteLine("No cars in stock");
                        }

                        break;
                    case 3:
                        //check out
                        if (CarStore.ShoppingList.Count > 0)
                        {
                            //checks if theres anything in the list
                            printShoppingCart(CarStore);
                            Console.WriteLine("Your total cost is $(0)", CarStore.checkout());
                        }
                        else
                        {
                            Console.WriteLine("Cart is empty");
                        }

                        break;
                    default:
                        break;
                }
            }
        }

        static public int chooseAction(int type)
        {
            int choice = 0;
            switch (type)
            {
                case 1:
                    Console.WriteLine("Choose an action (0) quit (1) add a car (2) add item to cart (3) checkout");
                    break;
                case 2:
                    Console.WriteLine("Choose an action (0) back (1) add manually (2) add generic");
                    break;
                case 3:
                    Console.WriteLine("Enter amount of cars to generate");
                    break;
                default:
                    break;
            }
            choice = Convert.ToInt32(Math.Floor(Convert.ToDecimal(userNumber())));
            //kind of overloaded but here is the thought process.
            //Get it to a decimal, and constantly round it down, so 2.9 is a user input of 2, because the first number is the number 2.
            //then convert it all back in to int
            Console.WriteLine(choice);
            return choice;
        }

        static private object userNumber()
        {
            float r = 0;
            do
            {
                if (float.TryParse(Console.ReadLine(), out r))
                {
                    return r;
                }
                else
                {
                    Console.WriteLine("Incorrect Input. Please enter a number");
                    r = -1;
                }
            } while (true);
        }

        static public void printStoreInventory(Store carStore)
        {
            Console.WriteLine("These are the cars in the store inventory:");
            int i = 0;
            foreach (var c in carStore.CarList)
            {
                Console.WriteLine(String.Format("{0} {1}", i , c.Display));
                i++;
            }
        }


        static public void printShoppingCart(Store carStore)
        {
            Console.WriteLine("Thse are the cars in your shopping cart:");
            int i = 0;
            foreach (var c in carStore.ShoppingList)
            {
                Console.WriteLine(String.Format("{0} {1}", i, c.Display));
                i++;
            }
        } 
    }
}
