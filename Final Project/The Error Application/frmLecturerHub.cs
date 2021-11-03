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
    public partial class frmLecturerHub : Form
    {
        public frmLecturerHub()
        {
            InitializeComponent();
        }

        private void btnToTopic_Click(object sender, EventArgs e)
        {
            frmTopics frmTopics = new frmTopics();
            frmTopics.Show();
            this.Hide();
        }

        private void btnToSol_Click(object sender, EventArgs e)
        {
            frmSolution frmSolution = new frmSolution();
            frmSolution.Show();
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

        private void btnAssignSol_Click(object sender, EventArgs e)
        {
            frmErrorSolution frmErrorSolution = new frmErrorSolution();
            frmErrorSolution.Show();
            this.Hide();
        }
    }
}
