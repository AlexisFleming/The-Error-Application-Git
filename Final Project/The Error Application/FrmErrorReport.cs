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
    public partial class FrmErrorReport : Form
    {
        public FrmErrorReport()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void FrmErrorReport_Load(object sender, EventArgs e)
        {
            //StudentInfo.DataSource = BLL.LecturerInformationReport();

            StudentIDcmb.DataSource = bll.GetError();
            StudentIDcmb.DisplayMember = "StudentID";
            StudentIDcmb.ValueMember = "StudentID";

            lecturerIDcmb.DataSource = bll.GetSolution();
            lecturerIDcmb.DisplayMember = "LecturerID";
            lecturerIDcmb.ValueMember = "LecturerID";

        }



        private void button1_Click(object sender, EventArgs e)
        {//student error display button
            DataTable dt = new DataTable();
            dt = bll.GetErrorByID(int.Parse(dgvError.SelectedRows[0].Cells["StudentID"].Value.ToString()));


            StudentIDcmb.Text = dt.Rows[0]["StudentID"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {//lecturer solution display button
            DataTable dt = new DataTable();
            dt = bll.GetSolutionByID(int.Parse(dgvSolution.SelectedRows[0].Cells["LecturerID"].Value.ToString()));


            lecturerIDcmb.Text = dt.Rows[0]["LecturerID"].ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }

        private void StudentIDcmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
