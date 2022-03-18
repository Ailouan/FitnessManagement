using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessManagement
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        Boolean b = true;
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
            }
        }

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMember m = new NewMember();
            m.Show();
            this.Hide();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStaff s = new NewStaff();
            s.Show();
            this.Hide();
        }

        private void deletMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment eq = new Equipment();
            eq.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void ewitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearshMember sm = new SearshMember();
            sm.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMember d = new DeleteMember();
            d.Show();
            this.Hide();
        }
    }
}
