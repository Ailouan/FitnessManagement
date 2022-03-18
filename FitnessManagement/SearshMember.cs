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
    public partial class SearshMember : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=ACER-PC\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True");
        public SearshMember()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public void dgv()
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
        private void SearshMember_Load(object sender, EventArgs e)
        {
            dgv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
            this.Hide();
        }
    }
}
