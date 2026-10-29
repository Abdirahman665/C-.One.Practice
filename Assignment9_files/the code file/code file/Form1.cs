using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment9_files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnreading_Click(object sender, EventArgs e)
        {
            StreamReader reader;
            try
            {
                listBox1.Items.Clear();

                reader = File.OpenText("C:\\Users\\Sidow\\Desktop\\C#.Practice\\C#.One.Practice\\Assignment9_files\\Assign_files.txt");

                while (reader.EndOfStream == false)
                {
                    string line;
                    line = reader.ReadLine();
                    listBox1.Items.Add(line);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            File.Delete("C:\\Users\\Sidow\\Desktop\\C#.Practice\\C#.One.Practice\\Assignment9_files\\Assign_files.txt");
        }
    }
}
