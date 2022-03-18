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
    public partial class DeleteMember : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=ACER-PC\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True");
        public DeleteMember()
        {
            InitializeComponent();
        }
        public void dgd()
        {
            cnx.Open();
            string cm = "select * from NewMember";
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand(cm, cnx);
            DataTable dt = new DataTable();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            cnx.Close();
        }
        private void DeleteMember_Load(object sender, EventArgs e)
        {
            dgd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sid.Text == "")
            {
                MessageBox.Show("Enter Member ID");
            }
            else
            {
                cnx.Open();
                try
                {
                    string cm = "select * from NewMember where MID = '" + sid.Text + "'";
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand(cm, cnx);
                    DataTable dt = new DataTable();
                    dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Member pas trouve !! ");
                }
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
            if (sid.Text == "")
            {
                MessageBox.Show("Enter Member ID");
            }
            else
            {
                //try
                //{
                    cnx.Open();
                    string cm = "delete NewMember where MID = '" + sid.Text + "'";
                    SqlCommand cmd = new SqlCommand(cm, cnx);
                    cmd.ExecuteNonQuery();
                    dgd();
                    cnx.Close();
                    MessageBox.Show("Member bien Supprime ");
                //}
                //catch
                //{
                //    MessageBox.Show("Member pas trouve !! ");
                //}
            }
        }
    }
}
