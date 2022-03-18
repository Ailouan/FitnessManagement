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
    public partial class NewMember : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=ACER-PC\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True");
        public NewMember()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fname.Clear();
            lname.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            address.Clear();
            dateTimePicker1.Value = DateTime.Now;
            mobil.Clear();
            email.Clear();
            dateTimePicker2.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gender = "";
            bool isCheked = radioButton1.Checked;
            if (isCheked)
            {
                gender = this.fname.Text;
            }
            else
            {
                gender = this.lname.Text;
            }

            if (fname.Text == "" || lname.Text == "" || gender == "" || mobil.Text == "" || email.Text == "" || address.Text == "" || address.Text == "")
            {
                MessageBox.Show("Merci de remplier tous les champes");
            }
            else
            {
                cnx.Open();
                string cm = "insert into NewMember values ('" + fname.Text + "','" + lname.Text + "','" + gender + "','" + dateTimePicker1.Value + "','" + mobil.Text + "','" + email.Text + "','" + dateTimePicker2.Value + "','" + comboBox1.Text + "','" + address.Text + "','" + comboBox2.Text + "')";
                SqlCommand cmd = new SqlCommand(cm, cnx);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member bien Ajoute !!");
                cnx.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            menu f = new menu();
            f.Show();
            this.Hide();
        }
    }
}
