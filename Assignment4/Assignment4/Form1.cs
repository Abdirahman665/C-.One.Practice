using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
          
            try
            {
                double hours = double.Parse(hoursWorkedTextBox.Text);
                double rate = double.Parse(hourlyPayRateTextBox.Text);

                // Validation
                if (hours < 0 || rate < 0)
                {
                    MessageBox.Show("Please enter positive numbers.");
                    return;
                }

                // Nested Loop
                string[] values = {
            hoursWorkedTextBox.Text,
            hourlyPayRateTextBox.Text
        };

                for (int i = 0; i < values.Length; i++)
                {
                    for (int j = 0; j < values[i].Length; j++)
                    {
                        if (!char.IsDigit(values[i][j]) && values[i][j] != '.')
                        {
                            MessageBox.Show("Please enter numbers only.");
                            return;
                        }
                    }
                }

                double grossPay;

                // Overtime calculation
                if (hours <= 40)
                {
                    grossPay = hours * rate;
                }
                else
                {
                    double overtimeHours = hours - 40;

                    grossPay = (40 * rate) +
                               (overtimeHours * rate * 1.5);
                }

                // Gross Pay is a LABEL
                grossPayLabel.Text = grossPay.ToString("0.00");
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
