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
    public partial class create_account : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cAString"].ConnectionString);
        public create_account()
        {
            InitializeComponent();
        }

        private void lble_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
           
            SqlCommand command = new SqlCommand();
            command.Connection = connection;




            command.CommandText = "Insert INTO users (name,password,Email,Gender)VALUES('"+this.textBox1.Text+"','"+this.textBox2.Text+"','"+this.textBox3.Text+"','"+this.comboBox1.SelectedItem.ToString()+"')";
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            home h =new home();
            this.Hide();
            h.ShowDialog();










        }

        private void create_account_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
