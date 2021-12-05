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
    public partial class Schedule_Maintenance : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = securedesigncoursedatabase.database.windows.net; Initial Catalog = airabc; User ID = securedesign; Password=MyiPhone3gS;Connect Timeout = 60; Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Schedule_Maintenance()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createNewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateRecord form3 = new CreateRecord();
            form3.Show();
            this.Hide();
            
        }

        private void enigeneersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EngineerList engineerList = new EngineerList();
            engineerList.Show();
            this.Hide();
        }

        private void engineersTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Engineer_Tasks engineer_Tasks = new Engineer_Tasks();
            engineer_Tasks.Show();
            this.Hide();
        }

        private void logFlightHoursToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Flight_Hours flight_Hours = new Flight_Hours();
            flight_Hours.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string InsertQuery = "Insert into Schedule(wings_maintenance,fuselag_maintenance,tail_maintenance,landing_maintenance)Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(InsertQuery, conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Stored");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Schedule", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
