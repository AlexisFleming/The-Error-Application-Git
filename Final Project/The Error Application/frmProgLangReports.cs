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
    public partial class frmProgLangReports : Form
    {
        public frmProgLangReports()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void frmProgLangReports_Load(object sender, EventArgs e)
        {//Loads the datagrid view with list of errors
            //Loads combo box with error Discriptions
            dgvProgLangReport.DataSource = bll.GetError();

            cmbErrorDescript.DataSource = bll.GetError();

            cmbErrorDescript.DisplayMember = "ErrorDescription";

            cmbErrorDescript.ValueMember = "ErrorDescription";

        }

        private void btnMostQuest_Click(object sender, EventArgs e)
        {

            dgvProgLangReport.DataSource = bll.GetMostProgQuest();

        }

        private void btnProgLeastAnswered_Click(object sender, EventArgs e)
        {
            dgvProgLangReport.DataSource = bll.GetLeastProgAnswered();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProgramLang frmProgramLang = new frmProgramLang();
            frmProgramLang.Show();
            this.Hide();
        }

        private void btnProgSameLangReport_Click(object sender, EventArgs e)
        {


            string sErrorDescrtiption;

            sErrorDescrtiption = cmbErrorDescript.Text;

            dgvProgLangReport.DataSource = bll.ProgLangDiffLang(sErrorDescrtiption);
        }

        private void dgvProgLangReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
