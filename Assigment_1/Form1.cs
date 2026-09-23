using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dayof_week,name_of_month, numeric, year, Full_date;


            dayof_week = textdhyoftheweek.Text;
            name_of_month = textmonth.Text;
            numeric = textnemoricofthemonth.Text;
            year = textoftheyear.Text;

            Full_date = dayof_week + "," + name_of_month + "," + numeric + "," + year;

            lbloutput.Text = Full_date;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textdhyoftheweek.Clear();
            textnemoricofthemonth.Text = string.Empty;
            textmonth.Text = "";
            textoftheyear.Clear();

            lbloutput.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
