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
    public partial class ViewEauipment : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=ACER-PC\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True");
        public ViewEauipment()
        {
            InitializeComponent();
        }
        public void dqv()
        {
            cnx.Open();
            string cm = "select * from Equipment";
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand(cm, cnx);
            DataTable dt = new DataTable();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            cnx.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
            this.Hide();
        }

        private void ViewEauipment_Load(object sender, EventArgs e)
        {
            dqv();
        }
    }
}
