/*
 * Name: Dylan Hardy
 * Date: 10/25/23
 * Purpose: class for pizza app
 */
 using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pizza_Delivery_Company
{
    internal class Order
    {
        //constant for the price of one bread stick
        const double BREADSTICK_UNIT_COST = 0.75;    

        //contact info members
        private string name;
        private string phone;
        private string address;
        private string email;

        //members for items names and prices
        private double pizzaCost;
        private string sauce;
        private string size;
        private string crust;
        private double crustCost;
        private double toppingCost;
        private string wingSauce;
        private int wingQuant;
        private int breadStickQuant;
        private double breadStickCost;
        private string drinkName;
        private double drinkCost;

        //default constructor
        public Order()
        {
            name = "Unknown";
            phone = "Unknown";
            address = "Unknown";
            email = "Unknown";
            pizzaCost = 0.0;
            sauce = "Unknown";
            crust = "Unknown";
            crustCost = 0.0;
            toppingCost = 0.0;
            wingSauce = "Unknown";
            wingQuant = 0;
            breadStickQuant = 0;
            breadStickCost = 0.0;
            drinkName = "Unknown";
            drinkCost = 0.0;
        }
        
        
        //property to get and set name member
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //property to get and set phone member
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        //property to get and set the address member
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        //property to get and set the email member
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        //property to get and set the pizzaCost member
        public double PizzaCost
        {
            get { return pizzaCost; }
            set { pizzaCost = value; }
        }

        //property to get and set the sauce member
        public string Sauce
        { 
            get { return sauce; }
            set {  sauce = value; }
        }

        //property to get and set the size member
        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        //property to get and set the crust member
        public string Crust
        {
            get { return crust; }
            set { crust = value; }
        }

        //property to get and set the crustCost member
        public double CrustCost
        {
            get { return crustCost;}
            set { crustCost = value; }
        }

        //property to get and set toppingCost
        public double ToppingCost
        {
            get { return toppingCost; }
            set { toppingCost = value; }
        }

        //property to get and set wingSauce
        public string WingSauce
        {
            get { return wingSauce; }
            set { wingSauce = value; }
        }

        //property to get and set wingQuant
        public int WingQuant
        {
            get { return wingQuant; }
            set { wingQuant = value; }
        }

        //property to get and set breadStickQuant
        public int BreadStickQuant
        {
            get { return  breadStickQuant; }
            set { breadStickQuant = value; }
        }

        //property to get and set breadStickCost
        public double BreadStickCost
        {
            get { return breadStickCost; }
            set { breadStickCost = value; }
        }

        //property to get and set drinkName
        public string DrinkName
        {
            get { return drinkName; }
            set { drinkName = value; }
        }

        //property to get and set drinkCost
        public double DrinkCost
        {
            get { return drinkCost; }
            set { drinkCost = value; }
        }

        //method to calculate the total cost by adding individual costs together
        public double DetermineTotalCharges()
        {
            return PizzaCost + CrustCost + ToppingCost + WingQuant + BreadStickCost + DrinkCost;
        }

        //method to calculate the breadstick cost by multiplying the quantity by the price of one
        public double DetermineBreadstickCost()
        {
            return BREADSTICK_UNIT_COST * BreadStickQuant;
        }

        //override ToString method to display class info
        public override string ToString()
        {
            return "Contact Info\nName: " + Name + "\nPhone: " + Phone + "\nAddress: "
                + Address + "\nEmail: " + Email +

                 "\n\nOrder \nPizza size: " + Size + "\nSauce: " + Sauce +
                "\nCrust: " + Crust + "\nWing Quantity: " + WingQuant + "\nWing Sauce: " + WingSauce +
                "\nBreadstick Quantity: " + BreadStickQuant + "\nDrink: " + DrinkName +
                "\n\nCost\nPizza Cost: $" + PizzaCost + "\nCrust Cost: $" + CrustCost.ToString("0.00") +
                "\nTopping Cost: $" + ToppingCost + "\nWing Cost: $" + WingQuant.ToString("0.00") +
                "\nBreadstick Cost: $" + BreadStickCost.ToString("0.00") + 
                "\nDrink Cost: $" + DrinkCost.ToString("0.00") +
                "\nTotal Due: $" + DetermineTotalCharges().ToString("0.00");
        }

    }
}
