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
    public partial class frmTopics : Form
    {
        

        public frmTopics()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Topic topic = new Topic();
            topic.TopicDescription = txtDescription.Text;
            

            int x = bll.InsertTopic(topic);
            if (x > 0)
            {
                MessageBox.Show(x + " Added!!");
            }
            else
            {
                MessageBox.Show(x + " Added!!");
            }
        }

        private void frmTopics_Load(object sender, EventArgs e)
        {
           
        }

        
        private void dgvTopic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();

            dt = bll.GetTopicByID(int.Parse(dgvTopic.SelectedRows[0].Cells["TopicID"].Value.ToString()));            
           
            txtDescription.Text = dt.Rows[0]["TopicDescription"].ToString(); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Topic topic = new Topic();
            topic.TopicDescription = txtDescription.Text;            
            topic.TopicID = int.Parse(dgvTopic.SelectedRows[0].Cells["TopicID"].Value.ToString());

            int x = bll.UpdateTopic(topic);
            if(x>0)
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
            Topic topic = new Topic();
            topic.TopicID = int.Parse(dgvTopic.SelectedRows[0].Cells["TopicID"].Value.ToString());
            
            int x = bll.DeleteTopic(topic);
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
            dgvTopic.DataSource = bll.GetTopic();
        }

        private void moduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModule module = new frmModule();
            this.Hide();
            module.Show();
        }

        private void solutionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSolution solution = new frmSolution();
            this.Hide();
            solution.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void assignTopicsToModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModuleTopic modTop = new frmModuleTopic();
            this.Hide();
            modTop.Show();
        }
    }
}
