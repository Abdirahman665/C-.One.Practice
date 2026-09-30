using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void display_Click(object sender, EventArgs e)
        {
            
                double nights;
                double pricePerNight;
                string name = GuestName.Text;
                string room = roomtype.Text;



                nights =double.Parse(NumberNight.Text);
                pricePerNight=double.Parse(prices.Text);
                

                double basicCost = nights * pricePerNight;
                double serviceTax = basicCost * 0.10;
                double discount = basicCost * 0.05;

                double totalAmount = basicCost + serviceTax - discount;

                tax.Text = serviceTax.ToString("C2");
                Discount.Text = discount.ToString("C2");
                TotalAmount.Text = totalAmount.ToString("C2");
            
            
        }
    }
    
    

}
