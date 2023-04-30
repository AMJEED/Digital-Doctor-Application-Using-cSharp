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
    public partial class home : Form
    {




        string[] image = new string[5];
        int count =0;
        public home()
        {
            InitializeComponent();
            image[0] = @"C:\Users\Aqsa majeed\source\repos\Final_project\pictures\5.jpg";
            image[1] = @"C:\Users\Aqsa majeed\source\repos\Final_project\pictures\6.jpg";
            image[2] = @"C:\Users\Aqsa majeed\source\repos\Final_project\pictures\7.jpg";
            image[3] = @"C:\Users\Aqsa majeed\source\repos\Final_project\pictures\4.jpg";
            timer1.Interval = 5000; 

            timer1.Start();
        }

        private void lble_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (count < 4 && count >= 0)
            {

                this.pictureBox1.ImageLocation = image[count];
                count++;
            }
            else 
            {

                count = 0;
                this.pictureBox1.ImageLocation = image[count];

            }




        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hover_text(object sender, EventArgs e)
        {


            Cursor.Current = Cursors.Hand;
            
               




        }

        private void hover_text(object sender, MouseEventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {



            Cursor.Current = Cursors.Hand;
            this.Hide();
            doctors_selection a = new doctors_selection();
            a.ShowDialog();


        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {



            Cursor.Current = Cursors.Hand;
            this.Hide();
            consult_doctor_select a = new consult_doctor_select();
            a.ShowDialog();

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            test t = new test();
            this.Hide();
            t.ShowDialog();


        }

        private void textBox8_MouseClick(object sender, MouseEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://covid.gov.pk/");

        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {

            Form1 f = new Form1();
            f.ShowDialog();


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
