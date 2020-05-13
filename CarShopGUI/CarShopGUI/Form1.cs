using System;
using CarClassLibrary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        /*
         * Added Remove button
         * Cleaned up display
         * Added Error Notification(Let's the user know if there are any errors)
         * Implemented a simple forum design
         * Updated total cost to reflect whenever change happens
         * Added a Randomizer, simplifies entries to the inventory
         * Added a double click listener
         * 
         */


        Store store = new Store();

        BindingSource carListBinding = new BindingSource();
        BindingSource shoppingListBinding = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            SetBindings();
        }

        private void SetBindings()
        {
            carListBinding.DataSource = store.CarList;
            list_inventory.DataSource = carListBinding;
            list_inventory.DisplayMember = "Display";



            shoppingListBinding.DataSource = store.ShoppingList;
            list_shopping.DataSource = shoppingListBinding;
            list_shopping.DisplayMember = "Display";
        }

        private void CreateCar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean allow = true;
                //small check to make sure everything lines up.

                bn_Error.Visible = false;

                if ((String.IsNullOrEmpty(Tb_make.Text)) || (String.IsNullOrEmpty(Tb_model.Text)) || (String.IsNullOrEmpty(Tb_price.Text))
                    ||(String.IsNullOrEmpty(Tb_year.Text)) ||(String.IsNullOrEmpty(tb_Range.Text)))
                {
                    //check if the model,make, price and year are empty.
                    //decided that year is not a priority 
                    allow = false;
                    bn_Error.Visible = true;
                    bn_Error.Text = "Please, fill all parameters";
                }
                if (allow)
                {
                    bool complete = true;
                    String errors = "";
                    Car newCar = new Car();
                    newCar.Make = Tb_make.Text;     
                    newCar.Model = Tb_model.Text;
                    newCar.Electric = CB_electric.Checked;

                    //year is filled in
                    if (int.TryParse(Tb_year.Text,out int cyear)) {
                        //error checking
                        newCar.Year = cyear;
                        if (newCar.Year < 2019)
                        {
                            newCar.isNew = false;
                        }
                        else
                        {
                            newCar.isNew = true;
                        }
                    }
                    else
                    {
                        complete = false;
                        errors += "-Year ";
                    }
                    
                    if (Decimal.TryParse(Tb_price.Text,out Decimal cprice))
                    {
                        //error checking
                        newCar.Price = Decimal.Round(cprice, 2, MidpointRounding.AwayFromZero);
                    }else
                    {
                        complete = false;
                        errors += "-Price ";
                    }



                    //Check for Range number
                    if (int.TryParse(tb_Range.Text,out int crange))
                    {
                        newCar.Range = crange;
                    }else
                    {
                        complete = false;
                        errors += "-Range ";
                    }

                    if (complete)
                    {
                        // if it all worked out then this happens.
                        store.CarList.Add(newCar);
                        carListBinding.ResetBindings(false);
                    }else
                    {
                        bn_Error.Visible = true;
                        bn_Error.Text = "Please, Fix: "+errors;
                    }
                }
            }
            catch (Exception )
            {
                bn_Error.Visible = true;
                bn_Error.Text = "Please, fix entered parameters";
                throw;
            }
        }

        private void GenerateCar_Click(object sender, EventArgs a)
        {
            if (int.TryParse(tb_amount.Text,out int amount))
            {
                store.CarList.AddRange(store.generatedCars(amount));
                carListBinding.ResetBindings(false);
            }
            else
            {
                bn_Error.Visible = true;
                bn_Error.Text = "Please, fix amount to generate";
            }
        }

        private void AddCart_Click(object sender, EventArgs a)
        {
            if (!store.ShoppingList.Contains((Car)list_inventory.SelectedItem))
            {
                //double check its not in. Can't have duplicates!
                store.ShoppingList.Add((Car)list_inventory.SelectedItem);   //add to shopping

                lb_costtotal.Text = store.currentTotal().ToString("C");
                shoppingListBinding.ResetBindings(false);
            }
        }

        private void RemoveCart_Click(object sender, EventArgs a)
        {
            store.ShoppingList.Remove((Car)list_shopping.SelectedItem);

            lb_costtotal.Text = store.currentTotal().ToString("C");
            shoppingListBinding.ResetBindings(false);
        }

        private void Checkout_Click(object sender, EventArgs a)
        {
            decimal total = store.checkout();
            lb_costtotal.Text = total.ToString("C");
        }

        private void Generate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(tb_amount.Text, out int amount))
                {
                    store.CarList.AddRange(store.generatedCars(amount));
                    carListBinding.ResetBindings(false);
                }
                else
                {
                    bn_Error.Visible = true;
                    bn_Error.Text = "Please, fix amount to generate";
                }
            }
        }

    }
}
