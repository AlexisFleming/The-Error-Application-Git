using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Error_Application
{
    public partial class frmErrorSolution : Form
    {
        public frmErrorSolution()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLecturerHub frmLecturerHub = new frmLecturerHub();
            frmLecturerHub.Show();
            this.Show();
        }
    }
}
