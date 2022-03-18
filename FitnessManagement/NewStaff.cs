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
    public partial class NewStaff : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=ACER-PC\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True");
        public NewStaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fname.Clear();
            lname.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            mobil.Clear();
            email.Clear();
            dateTimePicker2.Value = DateTime.Now;
            state.Clear();
            textBox6.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gender = "";
            bool isCheked = radioButton1.Checked;
            if (isCheked)
            {
                gender = fname.Text;
            }
            else
            {
                gender = lname.Text;
            }

            if (fname.Text == "" || lname.Text == "" || gender == "" || mobil.Text == "" || email.Text == "" || state.Text == "" || cyti.Text == "")
            {
                MessageBox.Show("Merci de remplier tous les champes");
            }
            else
            {
                cnx.Open();
                string cm = "insert into NewStaff values ('" + fname.Text + "','" + lname.Text + "','" + gender + "','" + dateTimePicker1.Value + "','" + mobil.Text + "','" + email.Text + "','" + dateTimePicker2.Value + "','" + state.Text + "','" + cyti.Text + "')";
                SqlCommand cmd = new SqlCommand(cm, cnx);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff bien Ajoute !!");
                cnx.Close();

            }
        }
    } 
}
