using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        double burger = 4.99;
        double fries = 2.50;
        double milkshake = 3.50;
        double numBurger;
        double numFries;
        double numMilk;
        double subTotal;
        double taxAmount;
        double totalAmount;
        double taxRate = 0.13;
        double numTendered;
        double change;
        double burgerTotal;
        double friesTotal;
        double milkTotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Understanding the input is how much of each item has been bought
                numBurger = Convert.ToDouble(burgerInput.Text);
                numFries = Convert.ToDouble(friesInput.Text);
                numMilk = Convert.ToDouble(milkshakeInput.Text);

                //Understanding how to calculate subtotal for each item
                burgerTotal = numBurger * burger;
                friesTotal = numFries * fries;
                milkTotal = numMilk * milkshake;

                //Understanding how to calculate subtotal for all items purchased.
                subTotal = burger * numBurger + fries * numFries + milkshake * numMilk;

                //Understanding how to calculate the amount of tax
                taxAmount = subTotal * taxRate;

                //Understanding how to calculate the total amount required to pay
                totalAmount = subTotal + taxAmount;

                //Displaying the amounts for each of subtotal, tax amount and total on screen in currency
                suboutputLabel.Text = subTotal.ToString("C");
                taxoutputLabel.Text = taxAmount.ToString("C");
                totaloutputLabel.Text = totalAmount.ToString("C");

                //Enabling the ability to put the money given and getting the change needed to be given back
                changeButton.Enabled = true;
                tenderedInput.Enabled = true;

                //Enabling the cash register sound and playing it
                SoundPlayer player = new SoundPlayer(Properties.Resources.Register);
                player.Play();
            }
            catch
            {
                //Displaying this message incase they inputed a letter
                outputLabel.Text = "Must Input Numbers Only";
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Understanding the input given is the amoun tof money given
                numTendered = Convert.ToDouble(tenderedInput.Text);
                
                //Calculating the change required to give back to customer
                change = numTendered - totalAmount;

                //Displaying the change required in currency
                changeoutputLabel.Text = change.ToString("C");

                //Enabling the button to print the reciept
                recieptButton.Enabled = true;

                //Enabling the cash register sound and playing it
                SoundPlayer player = new SoundPlayer(Properties.Resources.Register);
                player.Play();
            }
            catch
            {
                //Displaying this message incase they inputed a number
                outputLabel.Text = "Must Input Numbers Only";
            }
        }

        private void recieptButton_Click(object sender, EventArgs e)
        {
            //Enabling the printer sound and playing it
            SoundPlayer player = new SoundPlayer(Properties.Resources.Printer);
            player.Play();

            //Displaying the messages on the reciept and spacing them out half a second after another and displaying the money numbers in currency
            neworderButton.Enabled = true;
            outputLabel.Text = "Stratford Burger Palace";
            Refresh();
            Thread.Sleep(500);
            outputLabel.Text += "\n\nReciept Number 123";
            Refresh();
            Thread.Sleep(500);
            outputLabel.Text += "\n\nMay 4,2021    14:29:36";
            Refresh();
            Thread.Sleep(500);
            outputLabel.Text += $"\n\nBurgers        x{numBurger}={burgerTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            outputLabel.Text += $"\nFries             x{numFries}={friesTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            outputLabel.Text += $"\nMilkshakes   x{numMilk}={milkTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            outputLabel.Text += $"\n\nSubtotal            ={subTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            outputLabel.Text += $"\nTax                   ={taxAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            outputLabel.Text += $"\nTotal                 ={totalAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            outputLabel.Text += $"\n\nTendered         ={numTendered.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            outputLabel.Text += $"\nChange            ={change.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            outputLabel.Text += $"\n\nHave A Great Day!";
        }

        private void neworderButton_Click(object sender, EventArgs e)
        {
            //Erasing the messages for the reciept, subtotal, tax amount, total amount and change
            outputLabel.Text = "";
            suboutputLabel.Text = "";
            taxoutputLabel.Text = "";
            totaloutputLabel.Text = "";
            changeoutputLabel.Text = "";
            
            //Disbaling the change, reciept and new order button
            recieptButton.Enabled = false;
            changeButton.Enabled = false;
            neworderButton.Enabled = false;

            //Erasing the inputs for burgers, fries, milkshakes ordered and tendered
            burgerInput.Text = "";
            friesInput.Text = "";
            milkshakeInput.Text = "";
            tenderedInput.Text = "";
        }
    }

}