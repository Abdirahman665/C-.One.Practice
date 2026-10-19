using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
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

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                bool approved = true;

                string guestName = textBoxname.Text.Trim();

                int age, nights, guests;

                if (guestName == "")
                {
                    MessageBox.Show("Guest name cannot be empty.");
                    return;
                }

                if (!int.TryParse(textBoxage.Text, out age) ||
                    !int.TryParse(textBoxnights.Text, out nights) ||
                    !int.TryParse(textBoxnumberguest.Text, out guests))
                {
                    MessageBox.Show("Please enter valid numeric values.");
                    return;
                }

                if (age < 18 || age > 90)
                {
                    MessageBox.Show("Guest age must be between 18 and 90.");
                    return;
                }

                if (nights < 1 || nights > 30)
                {
                    MessageBox.Show("Number of nights must be between 1 and 30.");
                    return;
                }

                if (guests < 1 || guests > 6)
                {
                    MessageBox.Show("Number of guests must be between 1 and 6.");
                    return;
                }

                if (!radioButtonstandard.Checked &&
                    !radioButtonnormal.Checked &&
                    !radioButtonhight.Checked)
                {
                    MessageBox.Show("Please select a room type.");
                    return;
                }

                string roomType = "";
                double rate = 0;

                switch (true)
                {
                    case true when radioButtonstandard.Checked:
                        roomType = "Standard";
                        rate = 50;
                        if (guests > 2)
                            approved = false;
                        break;

                    case true when radioButtonnormal.Checked:
                        roomType = "Normal";
                        rate = 80;
                        if (guests > 4)
                            approved = false;
                        break;

                    case true when radioButtonhight.Checked:
                        roomType = "Hight";
                        rate = 130;
                        break;
                }

                if (!approved)
                {
                    MessageBox.Show("Booking rejected: too many guests for this room.");
                    return;
                }

                double subtotal = rate * nights;

                double discountRate = 0;

                if (nights >= 10)
                    discountRate = 0.12;
                else if (nights >= 5)
                    discountRate = 0.05;

                double discount = subtotal * discountRate;

                double breakfastCost = 0;

                if (checkBoxbreackfast.Checked)
                    breakfastCost = guests * nights * 10;

                double serviceCharge = 0;

                if (guests > 4)
                    serviceCharge = (subtotal - discount + breakfastCost) * 0.05;

                double seniorDiscount = 0;

                if (age >= 60)
                    seniorDiscount = (subtotal - discount) * 0.05;

                double total = subtotal - discount
                               + breakfastCost + serviceCharge
                               - seniorDiscount;

                Booking_details.Items.Clear();

                Booking_details.Items.Add("HOTEL ROOM BOOKING DETAILS");
                Booking_details.Items.Add("--------------------------------");
                Booking_details.Items.Add("Guest Name: " + guestName);
                Booking_details.Items.Add("Guest Age: " + age);
                Booking_details.Items.Add("Number of Nights: " + nights);
                Booking_details.Items.Add("Number of Guests: " + guests);
                Booking_details.Items.Add("Room Type: " + roomType);
                Booking_details.Items.Add("Rate Per Night: $" + rate);
                Booking_details.Items.Add("Room Cost: $" + subtotal.ToString("0.00"));
                Booking_details.Items.Add("Discount: $" + discount.ToString("0.00"));
                Booking_details.Items.Add("Breakfast: $" + breakfastCost.ToString("0.00"));
                Booking_details.Items.Add("Service Charge: $" + serviceCharge.ToString("0.00"));
                Booking_details.Items.Add("Senior Discount: $" + seniorDiscount.ToString("0.00"));
                Booking_details.Items.Add("--------------------------------");
                Booking_details.Items.Add("TOTAL: $" + total.ToString("0.00"));
                Booking_details.Items.Add("Booking Approved: " + approved);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBoxname.Clear();
            textBoxage.Clear();
            textBoxnights.Clear();
            textBoxnumberguest.Clear();

            radioButtonstandard.Checked = false;
            radioButtonnormal.Checked = false;
            radioButtonhight.Checked = false;

            checkBoxbreackfast.Checked = false;

            Booking_details.Items.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
