using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Air_ABC
{
    public partial class LogIn : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=securedesigncoursedatabase.database.windows.net;Initial Catalog=airabc;User ID=securedesign;Password=MyiPhone3gS;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public LogIn()
        {
            InitializeComponent();
        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            string Checkquery = "Select * from Users Where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
        
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Checkquery, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Enter a valid user name and password");
                }
                conn.Close();
            

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string InsertQuery = "Insert into Users(username,password)Values('" + textBox1.Text + "','" + textBox2.Text + "')";
            
            
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(InsertQuery, conn);
                sqlCommand.ExecuteNonQuery();
                
                MessageBox.Show("Record Stored");
                conn.Close();
            
        }
    }
}
