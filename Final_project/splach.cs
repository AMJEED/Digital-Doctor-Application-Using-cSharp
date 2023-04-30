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
    public partial class splach : Form
    {
        public splach()
        {
            InitializeComponent();
        }
        int count = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Interval= 100;
            this.timer1.Start();

            



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count+=1;
            this.lble_load.Text = ""+count;
            check();

            
        }
        public void check()
        {
            if (count == 100)
            {

                this.Hide();
                login f2 = new login();
                f2.ShowDialog();
                

            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lble_load_Click(object sender, EventArgs e)
        {

        }

        private void lble_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
