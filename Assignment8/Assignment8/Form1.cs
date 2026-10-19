using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment8
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

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                
                string customerName = txtname.Text.Trim();

                if (customerName == "")
                {
                    MessageBox.Show("Please enter customer name.");
                    txtname.Focus();
                    return;
                }

                
                int age;
                int days;
                int experience;

                if (!int.TryParse(txtage.Text, out age))
                {
                    MessageBox.Show("Please enter a valid customer age.");
                    txtage.Focus();
                    return;
                }

                if (!int.TryParse(txtdays.Text, out days))
                {
                    MessageBox.Show("Please enter valid rental days.");
                    txtdays.Focus();
                    return;
                }

                if (!int.TryParse(txtexperience.Text, out experience))
                {
                    MessageBox.Show("Please enter valid driving experience.");
                    txtexperience.Focus();
                    return;
                }

                
                if (age < 18 || age > 80)
                {
                    MessageBox.Show("Customer age must be between 18 and 80.");
                    return;
                }

                
                if (days < 1 || days > 30)
                {
                    MessageBox.Show("Rental days must be between 1 and 30.");
                    return;
                }

                
                if (experience < 0)
                {
                    MessageBox.Show("Driving experience cannot be negative.");
                    return;
                }

                
                string vehicleType = "";
                decimal dailyRate = 0;

                if (rdoeconomy.Checked)
                {
                    vehicleType = "Economy";
                    dailyRate = 35;
                }
                else if (rdosuv.Checked)
                {
                    vehicleType = "SUV";
                    dailyRate = 60;
                }
                else if (rdoluxury.Checked)
                {
                    vehicleType = "Luxury";
                    dailyRate = 100;
                }
                else
                {
                    MessageBox.Show("Please select a vehicle type.");
                    return;
                }

                
                bool approved = true;
                string rejectionReason = "";

                if (age < 21)
                {
                    approved = false;
                    rejectionReason = "Customer must be at least 21 years old.";
                }
                else if (experience < 1)
                {
                    approved = false;
                    rejectionReason =
                        "Customer must have at least 1 year of driving experience.";
                }
                else if (rdoluxury.Checked &&
                         (age < 25 || experience < 3))
                {
                    approved = false;
                    rejectionReason =
                        "Luxury vehicles require age 25 or above and at least 3 years of driving experience.";
                }

                
                lstresults.Items.Clear();

                lstresults.Items.Add("RENTAL DETAILS");
                lstresults.Items.Add("--------------------------------");

                lstresults.Items.Add("Customer Name: " + customerName);
                lstresults.Items.Add("Customer Age: " + age);
                lstresults.Items.Add("Driving Experience: " +
                                     experience + " years");
                lstresults.Items.Add("Vehicle Type: " + vehicleType);
                lstresults.Items.Add("Daily Rate: $" +
                                     dailyRate.ToString("0.00"));
                lstresults.Items.Add("Rental Days: " + days);

                
                if (!approved)
                {
                    lstresults.Items.Add("Basic Rental Cost: $0.00");
                    lstresults.Items.Add("Discount: $0.00");
                    lstresults.Items.Add("Insurance Cost: $0.00");
                    lstresults.Items.Add("Young Driver Surcharge: $0.00");
                    lstresults.Items.Add("Final Rental Cost: $0.00");
                    lstresults.Items.Add("--------------------------------");
                    lstresults.Items.Add("Rental Status: REJECTED");
                    lstresults.Items.Add("Reason: " + rejectionReason);

                    MessageBox.Show(rejectionReason,
                                    "Booking Rejected",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                
                decimal basicCost = dailyRate * days;

                
                decimal discountRate = 0;

                if (days >= 14)
                {
                    discountRate = 0.10m;
                }
                else if (days >= 7)
                {
                    discountRate = 0.05m;
                }

                decimal discount = basicCost * discountRate;

                // 12. Calculate insurance cost
                decimal insuranceCost = 0;

                if (chkinsurance.Checked)
                {
                    insuranceCost = 15m * days;
                }

                // 13. Calculate young driver surcharge
                decimal youngDriverSurcharge = 0;

                if (age >= 21 && age <= 24)
                {
                    youngDriverSurcharge = basicCost * 0.10m;
                }

                // 14. Calculate final rental cost
                decimal finalCost = basicCost - discount
                                    + insuranceCost
                                    + youngDriverSurcharge;

                // 15. Display all rental details
                lstresults.Items.Add("Basic Rental Cost: $" +
                                     basicCost.ToString("0.00"));

                lstresults.Items.Add("Discount (" +
                                     (discountRate * 100).ToString("0") +
                                     "%): -$" + discount.ToString("0.00"));

                lstresults.Items.Add("Insurance Cost: $" +
                                     insuranceCost.ToString("0.00"));

                lstresults.Items.Add("Young Driver Surcharge: $" +
                                     youngDriverSurcharge.ToString("0.00"));

                lstresults.Items.Add("--------------------------------");

                lstresults.Items.Add("Final Rental Cost: $" +
                                     finalCost.ToString("0.00"));

                lstresults.Items.Add("--------------------------------");
                lstresults.Items.Add("Rental Status: APPROVED");

                MessageBox.Show("Booking approved successfully!",
                                "Rental Status",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
          
            txtname.Clear();
            txtage.Clear();
            txtdays.Clear();
            txtexperience.Clear();

            rdoeconomy.Checked = false;
            rdosuv.Checked = false;
            rdoluxury.Checked = false;

            chkinsurance.Checked = false;

            lstresults.Items.Clear();

            txtname.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
    
}
