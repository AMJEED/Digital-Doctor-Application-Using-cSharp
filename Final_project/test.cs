using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Final_project
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }
       
        private void test_Load(object sender, EventArgs e)
        {

            SqlConnection connection;
            string connectionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select * from test";
            connection.Open();
            


            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {







                test_details t = new test_details();
                t.name = dataReader["name"].ToString();
                t.hospital = dataReader["hospital"].ToString();
                t.cost =(float) Convert.ToDecimal(dataReader["cost"]);
                listBox1.Items.Add(t);
               



            }
           

            dataReader.Close();
            connection.Close();




        }





        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            test_details tet = new test_details();


            tet = (test_details)this.listBox1.SelectedItem;
            this.textBox8.Text = tet.name;
            this.textBox9.Text = "" + tet.cost;
            this.textBox10.Text = tet.hospital;


        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            doctors_selection ds = new doctors_selection();
            this.Hide();
            ds.ShowDialog();
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {

            consult_doctor_select cds = new consult_doctor_select();
            this.Hide();
            cds.ShowDialog();



        }

        private void textBox11_MouseClick(object sender, MouseEventArgs e)
        {


               linkLabel2.LinkVisited = true;
               System.Diagnostics.Process.Start("https://covid.gov.pk/");



        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
