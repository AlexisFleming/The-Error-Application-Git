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
    public partial class frmSolution : Form
    {
        public frmSolution()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            solution Solution = new solution();

            
            Solution.SolutionDescription = txtDescription.Text;
            Solution.LecturerID = int.Parse(cmbLecture.Text);
            

            int x = BLL.AddSolution(Solution);

            if (x > 0)
            {
                MessageBox.Show(x + " Item Added");
            }
            else
            {
                MessageBox.Show(x + "Item Added");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            solution Solution = new solution();

            Solution.SolutionDescription = txtDescription.Text;
            Solution.LecturerID = int.Parse(cmbLecture.Text);

            int x = BLL.UpdateSolution(Solution);
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
            solution Solution = new solution();
            Solution.SolutionID = int.Parse(dgvSolution.SelectedRows[0].Cells["SolutionID"].Value.ToString());

            int x = BLL.DeleteSolution(Solution);
            if (x > 0)
            {
                MessageBox.Show(x + " Deleted!!");
            }
            else
            {
                MessageBox.Show(x + " Deleted!!");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {//this updates the data in the data grid
            dgvSolution.DataSource = BLL.GetSolution();
        }

        private void dgvSolution_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSolution.DataSource = BLL.GetSolution();
            if (dgvSolution.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                solution Solution = new solution();
                //getting user data based on value of ErrorID in the datagridview
                dt = BLL.GetSolution(int.Parse(dgvSolution.SelectedRows[0].Cells["ErrorID"].Value.ToString()));
                txtDescription.Text = dt.Rows[0]["SolutionDescription"].ToString();
                cmbLecture.Text = dt.Rows[0]["LecturerID"].ToString();
               



            }

        }

        private void frmSolution_Load(object sender, EventArgs e)
        {
            dgvSolution.DataSource = BLL.GetSolution();
        }
    }
}
