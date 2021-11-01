using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace The_Error_Application
{
    public partial class frmYear : Form
    {
        public frmYear()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {

            Year year = new Year();
            year.YearDescription = txtDescription.Text;

            int x = bll.InsertYear(year);
            if (x > 0)
            {
                MessageBox.Show(x + " Added!!");
            }
            else
            {
                MessageBox.Show(x + " Added!!");
            }
        }

        private void dgvYear_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bll.GetYearByID(int.Parse(dgvYear.SelectedRows[0].Cells["YearID"].Value.ToString()));
            txtDescription.Text = dt.Rows[0]["YearDescription"].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Year year = new Year();
            year.YearDescription = txtDescription.Text;
            year.YearID = int.Parse(dgvYear.SelectedRows[0].Cells["YearID"].Value.ToString());

            int x = bll.UpdateYear(year);
            if (x > 0)
            {
                MessageBox.Show(x + " Updated!!");
            }
            else
            {
                MessageBox.Show(x + " Updated!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Setting up a Yes No message box for user confirmation
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you wish to delete?", "Confirmation", buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                Year year = new Year();

                year.YearID = int.Parse(dgvYear.SelectedRows[0].Cells["YearID"].Value.ToString());

                int x = bll.DeleteYear(year);
                if (x > 0)
                {
                    MessageBox.Show(x + " Deleted!!");
                }
                else
                {
                    MessageBox.Show(x + " Deleted!!");
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvYear.DataSource = bll.GetYear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminHub frmAdminHub = new frmAdminHub();
            frmAdminHub.Show();
            this.Hide();
        }
    }
}
