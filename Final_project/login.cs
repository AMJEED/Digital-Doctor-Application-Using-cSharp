using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;



namespace Final_project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection connection;




        private void Form2_Load(object sender, EventArgs e)
        {




        }

      

        
        private void lble_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {


            this.Hide();
            create_account ac = new create_account();
            ac.ShowDialog();







        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select * from users";
            connection.Open();

            Boolean flag = false;
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {


                if (dataReader["name"].ToString() == this.textBox1.Text)
                {
                    if (dataReader["password"].ToString() == this.textBox2.Text)
                    {
                        flag = true;
                        this.Hide();
                        home h = new home();
                        h.ShowDialog();


                    }


                }



            }
            if (flag == false)
            {
                MessageBox.Show("Account not found !! If you dont have account , Create new Account  ");
            }
            dataReader.Close();
            connection.Close();




        }

     
           









     }

        

}

