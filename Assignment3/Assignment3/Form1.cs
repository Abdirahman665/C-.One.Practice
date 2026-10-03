using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
          
            try
            {
                double score1 = Convert.ToDouble(txtScore1.Text);
                double score2 = Convert.ToDouble(txtScore2.Text);
                double score3 = Convert.ToDouble(txtScore3.Text);

                if (score1 >= 0 && score1 <= 100 &&
                    score2 >= 0 && score2 <= 100 &&
                    score3 >= 0 && score3 <= 100)
                {
                    double average = (score1 + score2 + score3) / 3;

                    lblAverage.Text = average.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Scores must be between 0 and 100.");
                }
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }

        private void average_Click(object sender, EventArgs e)
        {

        }
    }
    
}
