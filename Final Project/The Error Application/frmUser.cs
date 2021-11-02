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
using System.Data.SqlClient;

namespace The_Error_Application
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void frmUser_Load(object sender, EventArgs e)
        {
            //This block of code sets up displays for the combo box and datagridview table
            //Clears edit boxes and diables relevent buttons

            dgvAdmin.DataSource = bll.GetUserInfo();

            cmbRole.DataSource = bll.GetRole();

            cmbRole.ValueMember = "RoleDescription";

            cmbRole.DisplayMember = "RoleDescription";

            btnLectReport.Enabled = false;
            btnAdd.Enabled = true;
            btnStudReport.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdminSort.Enabled = true;
            btnLectureSort.Enabled = true;
            btnStudentSort.Enabled = true;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnDiplay_Click(object sender, EventArgs e)
        {
            //Refreshes the data grid veiw
            dgvAdmin.DataSource = bll.GetUserInfo();

            //Enabling and disabling relevent buttons
            btnLectReport.Enabled = false;
            btnAdd.Enabled = true;
            btnStudReport.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdminSort.Enabled = true;
            btnLectureSort.Enabled = true;
            btnStudentSort.Enabled = true;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sRoleCheck;
            //Initiating an object and filling its values
            UserData userData = new UserData();
            userData.Username = txtFirstName.Text;
            userData.Surname = txtLastName.Text;
            userData.Email = txtEmail.Text;
            userData.Password = txtPassword.Text;
            sRoleCheck = cmbRole.Text;
            //Getting the Role ID based on chosen option in the combobox
            userData.RoleID = bll.GetRoleByID(sRoleCheck);
            //running the Insert procedure and returning a value to prove if it was successful
            int x = bll.InsertUser(userData);

            if (x == -1)
            {
                MessageBox.Show("Record added successfully.");
                dgvAdmin.DataSource = bll.GetUserInfo();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAdmin.SelectedRows.Count > 0)//Activates when a row in the datagrid view is selected
            {
                DataTable dt = new DataTable();
                UserData userInfo = new UserData();
                //getting user data based on value of UserID in the datagridview and filling in textboxes
                dt = bll.GetUserByID(int.Parse(dgvAdmin.SelectedRows[0].Cells["UserID"].Value.ToString()));
                txtFirstName.Text = dt.Rows[0]["Username"].ToString();
                txtLastName.Text = dt.Rows[0]["Surname"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtPassword.Text = dt.Rows[0]["Password"].ToString();

                //Enabling and disabling relevent buttons
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = false;
                btnAdminSort.Enabled = false;
                btnLectureSort.Enabled = false;
                btnStudentSort.Enabled = false;
                dgvAdmin.DataSource = dt;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sRoleCheck;
            //Initiating a new object and datatable and filling the oject's values
            DataTable dt = new DataTable();
            UserData userInfo = new UserData();
            userInfo.Username = txtFirstName.Text;
            userInfo.Surname = txtLastName.Text;
            userInfo.Email = txtEmail.Text;
            userInfo.Password = txtPassword.Text;

            //Code below gets UserID
            int iSelectedRow = dgvAdmin.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvAdmin.Rows[iSelectedRow];
            int iUserID = int.Parse(selectedRow.Cells["UserID"].Value.ToString());
            userInfo.UserID = iUserID;

            sRoleCheck = cmbRole.Text;
            
            userInfo.RoleID = bll.GetRoleByID(sRoleCheck); //getting RoleID from what was chosen in the combobox



            int x = bll.UpdateUser(userInfo);//Updating tblUser and returning a value to see if a record was added
            if (x ==-1)
            {
                MessageBox.Show("Update Successful");
                //Refreshes the data grid veiw
                dgvAdmin.DataSource = bll.GetUserInfo();

                //Enabling and disabling relevent buttons
                btnLectReport.Enabled = false;
                btnAdd.Enabled = true;
                btnStudReport.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnAdminSort.Enabled = true;
                btnLectureSort.Enabled = true;
                btnStudentSort.Enabled = true;
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Update failed");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Setting up a Yes No message box for user confirmation
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you wish to delete?", "Confirmation", buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {   
                UserData userInfo = new UserData();
                
                //The Promised land code that gets UserID from the datagrid view
                int iSelectedRow = dgvAdmin.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAdmin.Rows[iSelectedRow];
                int iUserID = int.Parse(selectedRow.Cells["UserID"].Value.ToString());                
                userInfo.UserID = iUserID;

                

                int x = bll.DeleteUser(userInfo);//Running the delete procedure and eturning a value to see if a record was deleted

                if (x == -1)
                {
                    MessageBox.Show("Delete Successful");
                    //Refreshes the data grid veiw
                    dgvAdmin.DataSource = bll.GetUserInfo();

                    //Enabling and disabling relevent buttons
                    btnLectReport.Enabled = false;
                    btnAdd.Enabled = true;
                    btnStudReport.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnAdminSort.Enabled = true;
                    btnLectureSort.Enabled = true;
                    btnStudentSort.Enabled = true;
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtEmail.Text = "";
                    txtPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Delete failed");
                }

                //MessageBox.Show(iUserID.ToString());

            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Delete canceled.");
            }
        }

        private void btnAdminSort_Click(object sender, EventArgs e)
        {
            //Filters dgvAdmin to show only Admin users
            dgvAdmin.DataSource = bll.AdminFilterReport();

            //Clears textboxes and disables irrelevent buttons
            btnLectReport.Enabled = false;
            btnStudReport.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void btnLectureSort_Click(object sender, EventArgs e)
        {
            //Filters dgvAdmin to show only Lecturer users
            dgvAdmin.DataSource = bll.LecturerFilterReport();
            //Clears textboxes and disables irrelevent buttons
            btnLectReport.Enabled = true;
            btnStudReport.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void btnStudentSort_Click(object sender, EventArgs e)
        {
            //Filters dgvAdmin to show only Student users
            dgvAdmin.DataSource = bll.StudentFilterReport();
            //Clears textboxes and disables irrelevent buttons
            btnLectReport.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnStudReport.Enabled = true;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void btnReportHelp_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show("To Generate a report you must.\n 1) Click either the Students or Lecturers buttons found in the Reports block.\n 2) Select on the DataGridView which record you want to use.\n 3) Then click the activated Get Report Button.", "Report Help", buttons, MessageBoxIcon.Information);
           
        }

        private void btnLectReport_Click(object sender, EventArgs e)
        {
            //This code gets the user ID from the dgv display and gennerates a report for the selected user

            UserData userInfo = new UserData();

            //Code below gets UserID
            int iSelectedRow = dgvAdmin.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvAdmin.Rows[iSelectedRow];
            int iUserID = int.Parse(selectedRow.Cells["UserID"].Value.ToString());
            userInfo.UserID = iUserID;

            dgvAdmin.DataSource = bll.LecturerInformationReport(userInfo);
        }

        private void btnStudReport_Click(object sender, EventArgs e)
        {
            //This code gets the user ID from the dgv display and gennerates a report for the selected user

            UserData userInfo = new UserData();

            //Code below gets UserID
            int iSelectedRow = dgvAdmin.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvAdmin.Rows[iSelectedRow];
            int iUserID = int.Parse(selectedRow.Cells["UserID"].Value.ToString());
            userInfo.UserID = iUserID;

            dgvAdmin.DataSource = bll.StudentInformationReport(userInfo);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Returns user to login form
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Hide();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRole roleForm = new frmRole();
            roleForm.Show();
            this.Hide();
        }

        private void progammingModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModule frmModule = new frmModule();
            frmModule.Show();
            this.Hide();
        }
    }
}
