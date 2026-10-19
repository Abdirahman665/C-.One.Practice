using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttoncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                
                int age;
                int tickets;
                double weight;

                if (int.TryParse(txtage.Text, out age))
                {
                    MessageBox.Show("Please enter a valid age.");
                    return;
                }
                else if (int.TryParse(txtticket.Text, out tickets))
                {
                    MessageBox.Show("Please enter a valid number of tickets.");
                    return;
                }
                else if (double.TryParse(txtwelghit.Text, out weight))
                {
                    MessageBox.Show("Please enter a valid baggage weight.");
                    return;
                }

               
                if (age < 1 || age > 100)
                {
                    MessageBox.Show("Age must be between 1 and 100.");
                    return;
                }
                else if (tickets < 1 || tickets > 5)
                {
                    MessageBox.Show("Tickets must be between 1 and 5.");
                    return;
                }
                else if (weight < 0 || weight > 50)
                {
                    MessageBox.Show("Baggage must be between 0 and 50 kg per passenger.");
                    return;
                }

               
                string travelClass = "";

                if (radioButtonfirst.Checked)
                {
                    travelClass = "First Class";
                }
                else if (radioButtonnormal.Checked)
                {
                    travelClass = "Normal Class";
                }
                else if (radioButtonbusines.Checked)
                {
                    travelClass = "Business Class";
                }
                else
                {
                    MessageBox.Show("Please select a travel class.");
                    return;
                }

                
                if (age < 12 && radioButtonfirst.Checked)
                {
                    MessageBox.Show("Booking rejected: passengers below 12 cannot book First Class.");
                    return;
                }

                
                double ticketPrice;

                switch (travelClass)
                {
                    case "First Class":
                        ticketPrice = 500;
                        break;

                    case "Normal Class":
                        ticketPrice = 200;
                        break;

                    case "Business Class":
                        ticketPrice = 350;
                        break;

                    default:
                        MessageBox.Show("Invalid travel class.");
                        return;
                }

               
                double basicCost = ticketPrice * tickets;
                double discountRate = 0;

               
                if (tickets >= 3 && tickets <= 4)
                {
                    discountRate += 0.05;
                }
                else if (tickets == 5)
                {
                    discountRate += 0.10;
                }
                else
                {
                    discountRate += 0;
                }

                
                if (age < 12)
                {
                    discountRate += 0.20;
                }
                else if (age >= 60)
                {
                    discountRate += 0.10;
                }

                double discount = basicCost * discountRate;
                double total = basicCost - discount;

                
                double insuranceCost = 0;

                if (checkBoxaddtravel.Checked)
                {
                    insuranceCost = 25 * tickets;
                }

                total += insuranceCost;

                
                listBoxoutput.Items.Clear();

                listBoxoutput.Items.Add("AIRLINE TICKET BOOKING");
                listBoxoutput.Items.Add("-------------------------");
                listBoxoutput.Items.Add("Passenger: " + txtname.Text);
                listBoxoutput.Items.Add("Age: " + age);
                listBoxoutput.Items.Add("Number of tickets: " + tickets);
                listBoxoutput.Items.Add("Baggage: " + weight + " kg per passenger");
                listBoxoutput.Items.Add("Travel class: " + travelClass);
                listBoxoutput.Items.Add("Ticket price: $" + ticketPrice);
                listBoxoutput.Items.Add("Basic cost: $" + basicCost);
                listBoxoutput.Items.Add("Discount: $" + discount);
                listBoxoutput.Items.Add("Insurance: $" + insuranceCost);

                if (weight <= 20)
                {
                    listBoxoutput.Items.Add("Baggage: Free");
                }
                else
                {
                    listBoxoutput.Items.Add("Baggage: Within the 50 kg limit; fee not specified");
                }

                listBoxoutput.Items.Add("-------------------------");
                listBoxoutput.Items.Add("Booking Approved");
                listBoxoutput.Items.Add("TOTAL: $" + total);
            }
            catch (Exception)
            {
                MessageBox.Show("An unexpected error occurred. Please check your input.");
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
           
            txtname.Clear();
            txtage.Clear();
            txtticket.Clear();
            txtwelghit.Clear();

            radioButtonfirst.Checked = false;
            radioButtonnormal.Checked = false;
            radioButtonbusines.Checked = false;

            checkBoxaddtravel.Checked = false;

            listBoxoutput.Items.Clear();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
    
}
