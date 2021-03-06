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
    public partial class Flight_Hours : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=securedesigncoursedatabase.database.windows.net;Initial Catalog=airabc;User ID=securedesign;Password=MyiPhone3gS;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Flight_Hours()
        {
            InitializeComponent();
        }

        private void createNewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateRecord form3 = new CreateRecord();
            form3.Show();
            this.Hide();
        }

        private void scheduleManitenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schedule_Maintenance form4 = new Schedule_Maintenance();
            form4.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void engineerssListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EngineerList engineerList = new EngineerList(); 
            engineerList.Show();
            this.Hide();
        }

        private void engineersMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Engineer_Tasks engineer_Tasks = new Engineer_Tasks();
            engineer_Tasks.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string InsertQuery = "Insert into Flight(flight_hours,total)Values('" + textBox2.Text + "','" + textBox3.Text + "')";
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(InsertQuery, conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Stored");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Flight ", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
