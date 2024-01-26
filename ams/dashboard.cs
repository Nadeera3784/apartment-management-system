using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ams
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void lblrecidential_Click(object sender, EventArgs e)
        {

        }

        private void lblresidential_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var madmin = new admin();
            madmin.Show();
        }

        private void restoreDastabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            datetoolstriplbl.Text = DateTime.Now.ToLongDateString();
            timetoolstriplbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timetoolstriplbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var mresidentail = new residentail();
            mresidentail.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var mowners = new owners();
            mowners.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var mtenant = new tenant();
            mtenant.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            var mpayment = new payment();
            mpayment.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            var mfloor = new floor();
            mfloor.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
