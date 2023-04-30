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
    public partial class doctors_selection : Form
    {
        public doctors_selection()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        List<doctor> doctors = new List<doctor>();
        public  doctor selected_doctor = new doctor() ;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void appointments_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select * from doctor";
            connection.Open();


            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {

                doctor d = new doctor();

               
                
                d.id = dataReader.GetInt32(dataReader.GetOrdinal("doc_id"));
                
               
                d.name = dataReader["name"].ToString();
                d.speciality = dataReader["speciality"].ToString();
                d.clinic = dataReader["clinic"].ToString();
                d.gender = dataReader["gender"].ToString();
                d.pic = dataReader["pic"].ToString();


                listBox1.Items.Add(d);
                doctors.Add(d);

               

            }
           

            dataReader.Close();
            connection.Close();





        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            doctor d =(doctor) this.listBox1.SelectedItem;;

            this.textBox9.Text = d.name;
            this.textBox10.Text = d.speciality;
            this.textBox11.Text = d.clinic;
            this.textBox12.Text = d.gender;
            this.pictureBox5.ImageLocation = d.pic;     
          

                 




        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            selected_doctor = (doctor)this.listBox1.SelectedItem;
           // MessageBox.Show("id" + selected_doctor.id);
            this.Hide();
            appointmnet_2 p2 = new appointmnet_2(selected_doctor);
            p2.ShowDialog();



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


            doctors_selection ds = new doctors_selection();
            this.Hide();
            ds.ShowDialog();










        }

        private void textBox8_MouseClick(object sender, MouseEventArgs e)
        {


            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://covid.gov.pk/");
        }
    }
}
