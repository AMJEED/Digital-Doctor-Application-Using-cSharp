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
    public partial class consult_doctor_select : Form
    {


       public static doctor sel_doctor = new doctor();
        public consult_doctor_select()
        {
            InitializeComponent();
        }

        private void consult_doctor_select_Load(object sender, EventArgs e)
        {
            SqlConnection connection;
            List<doctor> doctors = new List<doctor>();
           doctor selected_doctor = new doctor();

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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            doctor d = (doctor)this.listBox1.SelectedItem; ;

            this.textBox9.Text = d.name;
            this.textBox10.Text = d.speciality;
            this.textBox11.Text = d.clinic;
            this.textBox12.Text = d.gender;
            this.pictureBox5.ImageLocation = d.pic;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            sel_doctor =(doctor) this.listBox1.SelectedItem;
            consult c = new consult();
            this.Hide();
            c.ShowDialog();
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
    }
}
