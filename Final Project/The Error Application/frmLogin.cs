using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;

namespace The_Error_Application
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sRoleCHeck;
            DataTable dt = bll.GetLogin(txtUser.Text, txtPassword.Text);//Gets a record from tblUser if username and pasword match their respective fields in the database
            
            if(dt.Rows.Count>0) //If there is anything in the datatable then there is a match
            {
                sRoleCHeck = dt.Rows[0]["RoleID"].ToString();//Used to determine the RoleID of the selected record in order to determine what role the user belongs to
                ///////////////////////////////These if statements check to see what form to take the user based on their Role
                if (sRoleCHeck == "1")
                {//Takes Admin to admin form
                    frmAdminHub AdminStart = new frmAdminHub();
                    AdminStart.Show();
                    this.Hide();

                }
                else if (sRoleCHeck == "2")
                {//Takes Lecturer to lecture forms
                    frmLecturerHub LectureStart = new frmLecturerHub();
                    LectureStart.Show();
                    this.Hide();

                }
                else if (sRoleCHeck == "3")
                {//Takes student to student forms
                    frmError StudentStart = new frmError();
                    StudentStart.Show();
                    this.Hide();

                }             

            }
            else
            {//Displays if login fails
                MessageBox.Show("Incorrect Username or Password.");
            }
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {

            //Setting up a Yes No message box for user confirmation
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
