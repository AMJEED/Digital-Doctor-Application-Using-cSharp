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
    public partial class appointmnet_2 : Form
    {
        doctor dd;
        public appointmnet_2(doctor d)
        {
            this.dd = d;
            InitializeComponent();
        }
        int pat_id ;
        int doc_id ;
        string time;
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cAString"].ConnectionString);
        private void button1_Click(object sender, EventArgs e)
        {
           



            SqlCommand command = new SqlCommand();
            command.Connection = connection;




            command.CommandText = "Insert INTO patients (name,phone,Email,Gender)VALUES('" + this.textBox9.Text + "','" + this.textBox10 + "','" + this.textBox11 + "','" + this.comboBox1.ToString()+ "')";
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
           

            command.CommandText = "Select id from patients WHERE name = '"+ this.textBox9.Text + "'  AND phone = '"+this.textBox10+"' ";
            connection.Open();
             int  patient_id = (int)command.ExecuteScalar();
           // MessageBox.Show("  id "+patient_id);
            connection.Close();


            connection.Open();


            //MessageBox.Show("  id " + this.dd.id);
            command.Parameters.AddWithValue("@doc_id",(int)this.dd.id);
            command.Parameters.AddWithValue("@pat_id",(int) patient_id );
            command.Parameters.AddWithValue("@time", this.dateTimePicker1.Text);
         

            command.CommandText = "Insert INTO appointment (doctor_id,patient_id,timming)VALUES( @doc_id , @pat_id,'" +this.dateTimePicker1.Value.ToString()+"')";
            command.ExecuteNonQuery();
            MessageBox.Show("Your Appointment is booked successfully !! Timmings will communicate with you soon" +
                "Have a good Day");
            connection.Close();
            home h = new home();
            this.Hide();
            h.ShowDialog();


            
        }

        private void appointmnet_2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
