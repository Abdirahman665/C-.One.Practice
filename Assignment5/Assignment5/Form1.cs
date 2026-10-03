using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(txtNumber.Text);

                if (number >= 1 && number <= 10)
                {
                    lblDecision.Text = "The number is in the range.";
                }
                else
                {
                    lblDecision.Text = "The number is out of range.";
                }
            }
            catch (FormatException)
            {
                lblDecision.Text = "Please enter an integer.";
            }
            catch (Exception ex)
            {
                lblDecision.Text = ex.Message;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
