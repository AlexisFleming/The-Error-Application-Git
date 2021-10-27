using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace The_Error_Application
{
    public partial class frmRole : Form
    {
        public frmRole()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();      

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.RoleDescription = txtDescription.Text;

            int x = bll.InsertRole(role);
            if (x > 0)
            {
                MessageBox.Show(x + " Added!");
            }
            else
            {
                MessageBox.Show(x + " Added!");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvRole.DataSource = bll.GetRole();
        }
    }
}
