using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Error_Application
{
    public partial class frmAdminHub : Form
    {
        public frmAdminHub()
        {
            InitializeComponent();
        }

        private void btnToUsers_Click(object sender, EventArgs e)
        {
            frmUser frmUser = new frmUser();

            frmUser.Show();
            this.Hide();
        }

        private void btnProgLang_Click(object sender, EventArgs e)
        {
            frmProgramLang frmProgramLang = new frmProgramLang();
            frmProgramLang.Show();
            this.Hide();
        }

        private void btnToRole_Click(object sender, EventArgs e)
        {
            frmRole frmRole = new frmRole();
            frmRole.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                this.Hide();
            }


            
        }

        private void btnToYear_Click(object sender, EventArgs e)
        {
            frmYear frmYear = new frmYear();
            frmYear.Show();
            this.Hide();
        }
    }
}
