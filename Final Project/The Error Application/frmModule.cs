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
    public partial class frmModule : Form
    {
        public frmModule()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void frmModule_Load(object sender, EventArgs e)
        {
            cmbYear.DataSource = bll.GetYear();
            cmbYear.DisplayMember = "YearDescription";
            cmbYear.ValueMember = "YearID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Module mod = new Module();
            mod.ModuleDescription = txtDescription.Text;
            mod.YearID = int.Parse(cmbYear.SelectedValue.ToString());

            int x = bll.InsertModule(mod);
            if (x > 0)
            {
                MessageBox.Show(x + " Added!!");
            }
            else
            {
                MessageBox.Show(x + " Added!!");
            }
        }

        private void dgvModule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bll.GetModuleByID(int.Parse(dgvModule.SelectedRows[0].Cells["ModuleID"].Value.ToString()));

            txtDescription.Text = dt.Rows[0]["ModuleDescription"].ToString();
            cmbYear.Text = dt.Rows[0]["YearID"].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Module mod = new Module();
            mod.ModuleDescription = txtDescription.Text;
            mod.YearID = int.Parse(cmbYear.SelectedValue.ToString());
            mod.ModuleID = int.Parse(dgvModule.SelectedRows[0].Cells["ModuleID"].Value.ToString());

            int x = bll.UpdateModule(mod);
            if (x > 0)
            {
                MessageBox.Show(x + " Update!!");
            }
            else
            {
                MessageBox.Show(x + " Update!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Module mod = new Module();

            mod.ModuleID = int.Parse(dgvModule.SelectedRows[0].Cells["ModuleID"].Value.ToString());

            int x = bll.DeleteModule(mod);
            if (x > 0)
            {
                MessageBox.Show(x + " Delete!!");
            }
            else
            {
                MessageBox.Show(x + " Delete!!");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvModule.DataSource = bll.GetModule();
        }
    }
}
