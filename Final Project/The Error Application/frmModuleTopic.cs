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
    public partial class frmModuleTopic : Form
    {
        public frmModuleTopic()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void frmModuleTopic_Load(object sender, EventArgs e)
        {
            LoadTopic();
            LoadModule();
        }
        public void LoadTopic()
        {
            cmbTopic.DataSource = bll.GetTopic();
            cmbTopic.DisplayMember = "TopicDescription";
            cmbTopic.ValueMember = "TopicID";
        }
        public void LoadModule()
        {
           cmbModule.DataSource = bll.GetModule();
           cmbModule.DisplayMember = "ModuleDescription";
           cmbModule.ValueMember = "ModuleID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {                       
            ModuleTopic modTop = new ModuleTopic();
            modTop.TopicID = int.Parse(cmbTopic.SelectedValue.ToString());
            modTop.ModuleID = int.Parse(cmbModule.SelectedValue.ToString());

            int x = bll.InsertModuleTopic(modTop);
            if (x > 0)
            {
                MessageBox.Show(x + " Added!!");
            }
            else
            {
                MessageBox.Show(x + " Added!!");
            }
        }

        private void dgvModTopic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();            
            dt = bll.GetModuleTopicByID(int.Parse(dgvModTopic.SelectedRows[0].Cells["ModuleTopicID"].Value.ToString()));
            
            //Diplsay the topicdescription and moduledescription in cmb
            cmbTopic.Text = dt.Rows[0]["TopicID"].ToString();
            cmbModule.Text = dt.Rows[0]["ModuleID"].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ModuleTopic modTop = new ModuleTopic();
            modTop.TopicID = int.Parse(cmbTopic.SelectedValue.ToString());
            modTop.ModuleID = int.Parse(cmbModule.SelectedValue.ToString());
            modTop.ModuleTopicID = int.Parse(dgvModTopic.SelectedRows[0].Cells["ModuleTopicID"].Value.ToString());

            int x = bll.UpdateModuleTopic(modTop);
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
            ModuleTopic modTop = new ModuleTopic();          
            modTop.ModuleTopicID = int.Parse(dgvModTopic.SelectedRows[0].Cells["ModuleTopicID"].Value.ToString());

            int x = bll.DeleteModuleTopic(modTop);
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
            dgvModTopic.DataSource = bll.GetModuleTopic();
        }

        private void topicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTopics topic = new frmTopics();
            this.Hide();
            topic.Show();
        }

        private void solutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSolution solution = new frmSolution();
            this.Hide();
            solution.Show();
        }

        private void assignSolutionToErrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmErrorSolution errorSol = new frmErrorSolution();
            this.Hide();
            errorSol.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }
    }
}
