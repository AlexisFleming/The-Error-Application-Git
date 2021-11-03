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
    public partial class frmErrorSolution : Form
    {
        public frmErrorSolution()
        {
            InitializeComponent();
        }
        BusinessLogicLayer BLL = new BusinessLogicLayer();

        private void frmErrorSolution_Load(object sender, EventArgs e)
        {
            dgvErrorSolution.DataSource = BLL.GetErrorSolution();
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {// the code below adds the text in the combo boxes to the database
            ErrorSolution errorSolution = new ErrorSolution ();

            errorSolution.SolutionID = int.Parse(cmbSolution.Text);
            errorSolution.ErrorID = int.Parse(cmbError.Text);
            errorSolution.SolutionDate = int.Parse(dtpSolutionDate.Text);

            int x = BLL.ErrorSolutionAdd(errorSolution);
            if (x > 0)
            {
                MessageBox.Show(x + "Added");
            }
            else
            {
                MessageBox.Show(x + "Added");
            }

        }
        private void dgvErrorSolution_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BLL.GetErrorSolutionByID(int.Parse(dgvErrorSolution.SelectedRows[0].Cells["ErrorSolutionID"].Value.ToString()));

            //Diplsay the SolutionID and Error in the combo box
            cmbSolution.Text = dt.Rows[0]["SolutionID"].ToString();
            cmbError.Text = dt.Rows[0]["ErrorID"].ToString();
            dtpSolutionDate.Text = dt.Rows[0]["SolutionDate"].ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ErrorSolution errorSolution = new ErrorSolution();
            errorSolution.ErrorSolutionID = int.Parse(dgvErrorSolution.SelectedRows[0].Cells["ErrorSolutionID"].Value.ToString());

            errorSolution.SolutionID = int.Parse(cmbSolution.Text);
            errorSolution.ErrorID = int.Parse(cmbError.Text);
            errorSolution.SolutionDate = int.Parse(dtpSolutionDate.Text);

            int x = BLL.ErrorSolutionUpdate(errorSolution);
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
        {//this code deletes the selected 
            ErrorSolution errorSolution = new ErrorSolution();
            errorSolution.ErrorSolutionID = int.Parse(dgvErrorSolution.SelectedRows[0].Cells["ErrorSolutionID"].Value.ToString());

            int x = BLL.ErrorSolutionDelete(errorSolution);
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
        {
            dgvErrorSolution.DataSource = BLL.GetErrorSolution();
        }

        
    }
}
