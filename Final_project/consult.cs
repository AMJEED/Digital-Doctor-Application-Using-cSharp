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
    public partial class consult : Form
    {
        public consult()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cAString"].ConnectionString);
        private void consult_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            this.openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png | pdf |*.pdf"; ;
            
            this.openFileDialog1.Multiselect = false;
            openFileDialog1.RestoreDirectory = true;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

             SqlCommand command = new SqlCommand();
            command.Connection = connection;




            command.CommandText = "Insert INTO patients (name,phone,Email,Gender)VALUES('" + this.textBox9.Text + "','" + this.textBox10 + "','" + this.textBox11 + "','" + this.comboBox1.ToString()+ "')";
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();


            command.CommandText = "Select id from patients WHERE name = '" + this.textBox9.Text + "'  AND phone = '" + this.textBox10 + "' ";
            connection.Open();
            int patient_id = (int)command.ExecuteScalar();
           
            connection.Close();


            connection.Open();
            int doc_id = 0;
            int pat_id = 0;
            doctor dd = new doctor();
            dd = consult_doctor_select.sel_doctor;
            string query = "";
            string filePath = this.openFileDialog1.FileName;

           
            command.Parameters.AddWithValue("@doc_id", (int)dd.id);
            command.Parameters.AddWithValue("@pat_id", (int)patient_id);
            command.Parameters.AddWithValue("@query", this.textBox14.Text);
            command.Parameters.AddWithValue("@filePath", this.openFileDialog1.FileName);

            command.CommandText = "Insert INTO consult  VALUES ( @doc_id , @pat_id,'"+query+"','"+filePath+"')";
            command.ExecuteNonQuery();
            MessageBox.Show("Your Query is sent to the doctor" +
                 "Have a good Day");
            connection.Close();
            home h = new home();
            this.Hide();
            h.ShowDialog();





            
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
