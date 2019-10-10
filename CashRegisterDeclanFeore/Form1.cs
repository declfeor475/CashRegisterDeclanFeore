using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

/// <summary>
/// Created by Declan Feore
/// October 2019
/// Cash Register functions and printing receipts
/// </summary>

namespace CashRegisterDeclanFeore
{
    public partial class Form1 : Form
    {
        //global constants 
        const double HAMBURGER = 3;
        const double FRIES = 2;
        const double DRINK = 1.5;
        const double TAX = 0.13;

        //global variables
        int hamburgerAmount = 0;
        int friesAmount = 0;
        int drinkAmount = 0;
        double subTotal, totalWithTax, taxAmount;
        double amountTendered, amountChange;
        int initialize = 0;

        public Form1()
        {
            InitializeComponent();
        }
  
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //The number of each item wanted
                hamburgerAmount = Convert.ToInt16(hamburgerTextbox.Text);
                friesAmount = Convert.ToInt16(friesTextbox.Text);
                drinkAmount = Convert.ToInt16(drinksTextbox.Text);

                //Calculating price
                subTotal = hamburgerAmount * HAMBURGER + friesAmount * FRIES + drinkAmount * DRINK;
                taxAmount = subTotal * TAX;
                totalWithTax = subTotal + taxAmount;

                //Displaying the subtotal, tax, and total cost of the order with no error message
                displayLabel.Text = "" + subTotal.ToString("C");
                displayLabel.Text += "\n\n" + taxAmount.ToString("C");
                displayLabel.Text += "\n\n" + totalWithTax.ToString("C");
                messageLabel.Text = "";
            }
            catch
            {
                //error message
                messageLabel.Text = "Please insert a numeric value in each box!";
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //The amount tendered
                amountTendered = Convert.ToInt16(tenderedTextBox.Text);

                //Calculating change
                amountChange = amountTendered - totalWithTax;

                //Displaying amount of change owed with no error message
                changeLabel.Text = "" + amountChange.ToString("C");
                messageLabel.Text = "";
            }
            catch
            {
                //error message
                messageLabel.Text = "Please insert a numeric value in each box!";
            }
        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Graphics Settings
                Graphics g = this.CreateGraphics();
                Font receiptFont = new Font("Consolas", 12);
                SolidBrush receiptBrush = new SolidBrush(Color.Black);
                SoundPlayer receiptSound = new SoundPlayer(Properties.Resources.Register); 

                //The Receipt
                g.DrawString("The Burger Bin", receiptFont, receiptBrush, 370, 70);
                receiptSound.Play();

                Thread.Sleep(800);

                g.DrawString("Hamburger x" + hamburgerAmount + " " + HAMBURGER.ToString("C"), receiptFont, receiptBrush, 340, 95);
                receiptSound.Play();

                Thread.Sleep(800);

                g.DrawString("Fries x" + friesAmount + "     " + FRIES.ToString("C"), receiptFont, receiptBrush, 340, 110);
                receiptSound.Play();

                Thread.Sleep(800);

                g.DrawString("Drinks x" + drinkAmount + "    " + DRINK.ToString("C"), receiptFont, receiptBrush, 340, 125);
                receiptSound.Play();

                Thread.Sleep(800);

                g.DrawString("Subtotal     " + subTotal.ToString("C"), receiptFont, receiptBrush, 340, 155);
                receiptSound.Play();

                Thread.Sleep(800);

                g.DrawString("Tax          " + taxAmount.ToString("C"), receiptFont, receiptBrush, 340, 170);
                receiptSound.Play();

                Thread.Sleep(800);

                g.DrawString("Total        " + totalWithTax.ToString("C"), receiptFont, receiptBrush, 340, 185);
                receiptSound.Play();

                Thread.Sleep(800);

                g.DrawString("Tendered     " + amountTendered.ToString("C"), receiptFont, receiptBrush, 340, 215);
                receiptSound.Play();

                Thread.Sleep(800);

                g.DrawString("Change       " + amountChange.ToString("C"), receiptFont, receiptBrush, 340, 230);
                receiptSound.Play();

                Thread.Sleep(800);

                g.DrawString("Have a great day!", receiptFont, receiptBrush, 360, 260);
                receiptSound.Play();
            }
            catch
            {
                //error message
                messageLabel.Text = "Please fill out every box before printing receipt!";
            }
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            //Graphics Settings
            Graphics g = this.CreateGraphics();

            //Getting rid of the previous receipt
            g.Clear(Color.White);

            //Reseting textbox values
            hamburgerTextbox.Text = "";
            friesTextbox.Text = "";
            drinksTextbox.Text = "";
            tenderedTextBox.Text = "";
            
            //Reseting variables to zero so a new order can be placed
            hamburgerAmount = initialize;
            friesAmount = initialize;
            drinkAmount = initialize;

            subTotal = initialize;
            taxAmount = initialize;
            totalWithTax = initialize;

            amountTendered = initialize;
            amountChange = initialize;

            //Reseting labels to show no amounts so a new order can be placed
            displayLabel.Text = "";
            changeLabel.Text = "";
        }
    }
}
