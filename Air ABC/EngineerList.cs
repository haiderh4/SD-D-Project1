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
    public partial class EngineerList : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=securedesigncoursedatabase.database.windows.net;Initial Catalog=airabc;User ID=securedesign;Password=MyiPhone3gS;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public EngineerList()
        {
            InitializeComponent();
        }

        private void createRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateRecord createRecord = new CreateRecord();
            createRecord.Show();
            this.Hide();

        }

        private void logFlightHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flight_Hours flight_Hours = new Flight_Hours();
            flight_Hours.Show();
            this.Hide();
        }

        private void scheduleMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schedule_Maintenance schedule_Maintenance = new Schedule_Maintenance(); 
            schedule_Maintenance.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void engineersTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Engineer_Tasks engineer_Tasks = new Engineer_Tasks();
            engineer_Tasks.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string InsertQuery = "Insert into List(eng_name,eng_designation)Values('" + textBox2.Text + "','" + textBox3.Text + "')";
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(InsertQuery, conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Stored");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM List",conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource= dt;
            conn.Close();
        }
    }
}
