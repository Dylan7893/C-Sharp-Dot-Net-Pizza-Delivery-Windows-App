/*
 * Name: Dylan Hardy
 * Date: 10/25/23
 * Purpose: test order class
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Pizza_Delivery_Company
{
    public partial class Form1 : Form
    {
        
        //declare variable of order type
        private Order newOrder;
        public Form1()
        {
            InitializeComponent();
        }

        //create a new order object on load
        private void Form1_Load(object sender, EventArgs e)
        {
            newOrder = new Order();
        }

        
        //display message box with information on order with button click
        private void btn_order_Click(object sender, EventArgs e)
        {
           MessageBox.Show(newOrder.ToString()); 
        }

        //event handler to set pizza size and price to small
        private void rb_smallPizza_CheckedChanged(object sender, EventArgs e)
        {
            newOrder.PizzaCost = 9.99;
            newOrder.Size = "Small";
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges(); 
        }

        //event handler to set pizza size and price to medium
        private void rb_mediumPizza_CheckedChanged(object sender, EventArgs e)
        {
            newOrder.PizzaCost = 12.99;
            newOrder.Size = "Medium";
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler to set pizza size and price to large
        private void rb_largePizza_CheckedChanged(object sender, EventArgs e)
        {
            newOrder.PizzaCost = 14.99;
            newOrder.Size = "Large";
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler to change the name on order
        private void tbx_name_TextChanged(object sender, EventArgs e)
        {
            newOrder.Name = tbx_name.Text;
        }

        //event handler to change the address on order
        private void tbx_address_TextChanged(object sender, EventArgs e)
        {
            newOrder.Address = tbx_address.Text;
        }

        //event handler to change the email on order
        private void tbx_email_TextChanged(object sender, EventArgs e)
        {
            newOrder.Email = tbx_email.Text;
        }

        //event handler to change phone on the order
        private void tbx_phone_TextChanged(object sender, EventArgs e)
        {
            newOrder.Phone = tbx_phone.Text;
        }

        //event handler to change the sauce type
        private void lbx_sauce_SelectedIndexChanged(object sender, EventArgs e)
        {
            newOrder.Sauce = lbx_sauce.Text;
        }

        //event handler to change crust and price to original 
        private void rb_original_CheckedChanged(object sender, EventArgs e)
        {
            newOrder.Crust = "Original";
            newOrder.CrustCost = 0;
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler to change crust to supreme
        private void rb_supreme_CheckedChanged(object sender, EventArgs e)
        {
            newOrder.Crust = "Supreme";
            newOrder.CrustCost = 1.50;
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler to change crust to veggie
        private void rb_veggie_CheckedChanged(object sender, EventArgs e)
        {
            newOrder.Crust = "Veggie";
            newOrder.CrustCost = 1.50;
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler to add cheese as a topping
        private void cb_cheese_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_cheese.Checked)
                newOrder.ToppingCost += 1.0;
            else
                newOrder.ToppingCost -= 1.0;
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler to add pepperoni as a topping
        private void cb_pepperoni_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_pepperoni.Checked)
                newOrder.ToppingCost += 1.0;
            else
                newOrder.ToppingCost -= 1.0;
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler to add chicken as a topping
        private void cb_chicken_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_chicken.Checked)
                newOrder.ToppingCost += 1.0;
            else
                newOrder.ToppingCost -= 1.0;
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler to add ham as a topping
        private void cb_ham_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ham.Checked)
                newOrder.ToppingCost += 1.0;
            else
                newOrder.ToppingCost -= 1.0;
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler to add bacon as a topping
        private void cb_bacon_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_bacon.Checked)
                newOrder.ToppingCost += 1.0;
            else
                newOrder.ToppingCost -= 1.0;
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler to add sausage as a topping
        private void cb_sausage_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_sausage.Checked)
                newOrder.ToppingCost += 1.0;
            else
                newOrder.ToppingCost -= 1.0;
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler to add mushrooms as a topping
        private void cb_mushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mushrooms.Checked)
                newOrder.ToppingCost += 1.0;
            else
                newOrder.ToppingCost -= 1.0;
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler to add olives as a topping
        private void cb_olives_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_olives.Checked)
                newOrder.ToppingCost += 1.0;
            else
                newOrder.ToppingCost -= 1.0;
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler to add tomatoes as a topping
        private void cb_tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_tomatoes.Checked)
                newOrder.ToppingCost += 1.0;
            else
                newOrder.ToppingCost -= 1.0;
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler to add zucchini as a topping
        private void cb_zucchini_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_zucchini.Checked)
                newOrder.ToppingCost += 1.0;
            else
                newOrder.ToppingCost -= 1.0;
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler to add onions as a topping
        private void cb_onions_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_onions.Checked)
                newOrder.ToppingCost += 1.0;
            else
                newOrder.ToppingCost -= 1.0;
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler to add pineapple as a topping
        private void cb_pineapple_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_pineapple.Checked)
                newOrder.ToppingCost += 1.0;
            else
                newOrder.ToppingCost -= 1.0;
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler to set wing sauce to mild
        private void rb_mild_CheckedChanged(object sender, EventArgs e)
        {
            newOrder.WingSauce = "Mild";
        }
        
        //event handler to set wing sauce to medium
        private void rb_medium_CheckedChanged(object sender, EventArgs e)
        {
            newOrder.WingSauce = "Medium";
        }

        //event handler to set wing sauce to hot
        private void rb_hot_CheckedChanged(object sender, EventArgs e)
        {
            newOrder.WingSauce = "Hot";
        }

        //event handler to set wing sauce to barbecue
        private void rb_bbq_CheckedChanged(object sender, EventArgs e)
        {
            newOrder.WingSauce = "Barbecue";
        }

        //event handler to set the wing quantity
        private void tb_wingQuant_TextChanged(object sender, EventArgs e)
        {
            if (tb_wingQuant.Text == "")
                newOrder.WingQuant = 0;
            else
                newOrder.WingQuant = Convert.ToInt32(tb_wingQuant.Text);

            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();

        }

        //event handler to set the breadstick quantity
        private void tb_breadstickQuant_TextChanged(object sender, EventArgs e)
        {
            if (tb_breadstickQuant.Text == "")
                newOrder.BreadStickQuant = 0;
            else
                newOrder.BreadStickQuant = Convert.ToInt32(tb_breadstickQuant.Text);

            newOrder.BreadStickCost = newOrder.DetermineBreadstickCost();

            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler to set the drink to soda
        private void rb_soda_CheckedChanged(object sender, EventArgs e)
        {
            newOrder.DrinkName = "Soda";
            newOrder.DrinkCost = 1.50;
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler to set the drink to tea
        private void rb_tea_CheckedChanged(object sender, EventArgs e)
        {
            newOrder.DrinkName = "Tea";
            newOrder.DrinkCost = 1.50;
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler to set the drink to water
        private void rb_water_CheckedChanged(object sender, EventArgs e)
        {
            newOrder.DrinkName = "Water";
            newOrder.DrinkCost = 1.50;
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler to set drink to none
        private void rb_none_CheckedChanged(object sender, EventArgs e)
        {
            newOrder.DrinkName = "None";
            newOrder.DrinkCost = 0;
            lbl_total.Text = "Total: $" + newOrder.DetermineTotalCharges();
        }

        //event handler for the clear button
        private void btn_clear_Click(object sender, EventArgs e)
        {
            //setting all memebrs back to default values
            newOrder.Name = "Unknown";
            newOrder.Phone = "Unknown";
            newOrder.Address = "Unknown";
            newOrder.Email = "Unknown";
            newOrder.PizzaCost = 0.0;
            newOrder.Sauce = "Unknown";
            newOrder.Crust = "Unknown";
            newOrder.CrustCost = 0.0;
            newOrder.ToppingCost = 0.0;
            newOrder.WingSauce = "Unknown";
            newOrder.WingQuant = 0;
            newOrder.BreadStickQuant = 0;
            newOrder.BreadStickCost = 0.0;
            newOrder.DrinkName = "Unknown";
            newOrder.DrinkCost = 0.0;

            //unchecking all possible checkboxes
            rb_smallPizza.Checked = false;
            rb_mediumPizza.Checked = false;
            rb_largePizza.Checked = false;
            rb_original.Checked = false;
            rb_supreme.Checked = false;
            rb_veggie.Checked = false;
            cb_cheese.Checked = false;
            cb_pepperoni.Checked = false;
            cb_chicken.Checked = false;
            cb_ham.Checked = false;
            cb_bacon.Checked = false;
            cb_sausage.Checked = false;
            cb_mushrooms.Checked = false;
            cb_olives.Checked = false;
            cb_tomatoes.Checked = false;
            cb_zucchini.Checked = false;
            cb_onions.Checked = false;
            cb_pineapple.Checked = false;

            //setting textboxes to empty values
            tbx_address.Text = "";
            tbx_name.Text = "";
            tbx_phone.Text = "";
            tbx_email.Text = "";

            //unchecking radio buttons
            rb_bbq.Checked = false;
            rb_hot.Checked = false;
            rb_medium.Checked = false;
            rb_mild.Checked = false;

            //setting quantity textboxes to 0
            tb_breadstickQuant.Text = "0";
            tb_wingQuant.Text = "0";

            //unchecking drink radio buttons
            rb_soda.Checked = false;
            rb_tea.Checked = false;
            rb_water.Checked = false;
            rb_none.Checked = false;


            //set the total label back to empty string
            lbl_total.Text = "";

        }   
    
    }
}
