using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (this.comboBox1.SelectedItem.ToString() == "Male")
            {

                double calory = 66 + (6.2 * Convert.ToInt32(this.textBox10.Text)) + (12.7 * Convert.ToInt32(this.textBox9.Text) - (6.6 * Convert.ToInt32(this.textBox1.Text)));
                MessageBox.Show("You burned " + calory + "Calories");







            }
            else
            {
               
                double calory = 655.1 + (4.35* Convert.ToInt32(this.textBox10.Text)) + (4.7 * Convert.ToInt32(this.textBox9.Text) - (4.7 * Convert.ToInt32(this.textBox1.Text)));
                MessageBox.Show("You burned " + calory + "Calories");

            }




        }

        private void label3_Click(object sender, EventArgs e)
        {


            this.Dispose();



        }
    }
}
