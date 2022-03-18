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

namespace FitnessManagement
{
    public partial class Equipment : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=ACER-PC\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True");
        public Equipment()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewEauipment v = new ViewEauipment();
            v.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EquipName.Text == "" || des.Text == "" || msu.Text == "" || con.Text == "")
            {
                MessageBox.Show("Merci de remplier tous les champes");
            }
            else
            {
                cnx.Open();
                string cm = "insert into Equipment values ('"+ EquipName.Text + "','"+ des.Text + "','"+ msu.Text + "','"+ dateTimePicker1.Value + "','"+ con.Text + "');";
                SqlCommand cmd = new SqlCommand(cm, cnx);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Equipment bien Ajoute !!");
                cnx.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EquipName.Clear();
            des.Clear();
            msu.Clear();
            dateTimePicker1.Value = DateTime.Now;
            con.Clear();
        }
    }
}
