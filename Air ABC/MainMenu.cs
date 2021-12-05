using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_ABC
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateRecord form3 = new CreateRecord();
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Schedule_Maintenance form4 = new Schedule_Maintenance();
            form4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Flight_Hours flight_Hours = new Flight_Hours();
            flight_Hours.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EngineerList list = new EngineerList();
            list.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Engineer_Tasks engineer_Tasks = new Engineer_Tasks();
            engineer_Tasks.Show();
            this.Hide();
            
        }
    }
}
