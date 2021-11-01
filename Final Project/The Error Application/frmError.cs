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
    public partial class frmError : Form
    {
        public frmError()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
