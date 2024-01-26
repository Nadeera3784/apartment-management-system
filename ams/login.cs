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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
           
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            {
                String username = "kalani";
                String password = "123";
                if (txtusername.Text == username & txtpassword.Text == password)

                {

                    dashboard f2 = new dashboard();
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("invalid user name or password");
                }
            }
        }
    }
}
