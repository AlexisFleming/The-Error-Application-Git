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
using System.Data.SqlClient;


namespace The_Error_Application
{
    public partial class frmError : Form
    {
        BusinessLogicLayer BLL = new BusinessLogicLayer();

        public frmError()
        {
            InitializeComponent();
        }
        private void frmError_Load(object sender, EventArgs e)
        {
            dgvError.DataSource = BLL.GetError();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {//the code on this button adds the inputted information to the dataBase 
            error Error = new error();

           
            Error.ErrorDescription = txtDescription.Text;
            Error.StudentID = int.Parse(txtStudent.Text);
            Error.ProgLanguageID = txtProgram.Text;
            Error.ModuleTopicID = cmbTopic.Text;
            Error.ErrorStatus = txtError.Text;

            int x = BLL.AddError(Error);
            if (x > 0)
            {
                MessageBox.Show(x + " Item Added");
            }
            else
            {
                MessageBox.Show(x + " item Added");
            }

        }



        private void dgvError_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvError.DataSource = BLL.GetError();
            if (dgvError.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                UserData userInfo = new UserData();
                //getting user data based on value of ErrorID in the datagridview
                dt = BLL.GetUserByID(int.Parse(dgvError.SelectedRows[0].Cells["ErrorID"].Value.ToString()));
                txtDescription.Text = dt.Rows[0]["ErrorDescription"].ToString();
                txtStudent.Text = dt.Rows[0]["StudentID"].ToString();
                txtProgram.Text = dt.Rows[0]["ProgramLanguageID"].ToString();
                cmbTopic.Text = dt.Rows[0]["ModuleTopicID"].ToString();
                txtError.Text = dt.Rows[0]["ErrorStatus"].ToString();

                
               
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            error Error = new error();
            Error.ErrorID = int.Parse(dgvError.SelectedRows[0].Cells["ErrorID"].Value.ToString());
            Error.ErrorDescription = txtDescription.Text;
            Error.StudentID = int.Parse(txtStudent.Text);
            Error.ProgLanguageID = txtProgram.Text;
            Error.ModuleTopicID = cmbTopic.Text;
            Error.ErrorStatus = txtError.Text;

            int x = BLL.UpdateError(Error);
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
        {//this button deletes the row that is currently selected by the user 
            error Error = new error();
            Error.ErrorID = int.Parse(dgvError.SelectedRows[0].Cells["ErrorID"].Value.ToString());

            int x = BLL.DeleteError(Error);
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
        {//this button just updates the information in the data grid
            dgvError.DataSource = BLL.GetError();
        }

        private void frmError_Load_1(object sender, EventArgs e)
        {
            
        }
    }
    }



