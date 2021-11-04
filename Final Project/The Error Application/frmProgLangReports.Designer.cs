
namespace The_Error_Application
{
    partial class frmProgLangReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProgLangReport = new System.Windows.Forms.DataGridView();
            this.gpbProgLangReport = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProgLeastAnswered = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostQuest = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbErrorDescript = new System.Windows.Forms.ComboBox();
            this.btnProgSameLangReport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgLangReport)).BeginInit();
            this.gpbProgLangReport.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProgLangReport
            // 
            this.dgvProgLangReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgLangReport.Location = new System.Drawing.Point(12, 44);
            this.dgvProgLangReport.Name = "dgvProgLangReport";
            this.dgvProgLangReport.Size = new System.Drawing.Size(776, 138);
            this.dgvProgLangReport.TabIndex = 0;
            this.dgvProgLangReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProgLangReport_CellContentClick);
            // 
            // gpbProgLangReport
            // 
            this.gpbProgLangReport.Controls.Add(this.label3);
            this.gpbProgLangReport.Controls.Add(this.btnProgSameLangReport);
            this.gpbProgLangReport.Controls.Add(this.cmbErrorDescript);
            this.gpbProgLangReport.Controls.Add(this.label2);
            this.gpbProgLangReport.Controls.Add(this.btnProgLeastAnswered);
            this.gpbProgLangReport.Controls.Add(this.label1);
            this.gpbProgLangReport.Controls.Add(this.btnMostQuest);
            this.gpbProgLangReport.Location = new System.Drawing.Point(12, 203);
            this.gpbProgLangReport.Name = "gpbProgLangReport";
            this.gpbProgLangReport.Size = new System.Drawing.Size(776, 173);
            this.gpbProgLangReport.TabIndex = 1;
            this.gpbProgLangReport.TabStop = false;
            this.gpbProgLangReport.Text = "Reports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Show which Programming Language has the Least answers";
            // 
            // btnProgLeastAnswered
            // 
            this.btnProgLeastAnswered.Location = new System.Drawing.Point(9, 77);
            this.btnProgLeastAnswered.Name = "btnProgLeastAnswered";
            this.btnProgLeastAnswered.Size = new System.Drawing.Size(106, 23);
            this.btnProgLeastAnswered.TabIndex = 2;
            this.btnProgLeastAnswered.Text = "Generate Report";
            this.btnProgLeastAnswered.UseVisualStyleBackColor = true;
            this.btnProgLeastAnswered.Click += new System.EventHandler(this.btnProgLeastAnswered_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Show which Programming Language has most questions";
            // 
            // btnMostQuest
            // 
            this.btnMostQuest.Location = new System.Drawing.Point(9, 32);
            this.btnMostQuest.Name = "btnMostQuest";
            this.btnMostQuest.Size = new System.Drawing.Size(106, 23);
            this.btnMostQuest.TabIndex = 0;
            this.btnMostQuest.Text = "Generate Report";
            this.btnMostQuest.UseVisualStyleBackColor = true;
            this.btnMostQuest.Click += new System.EventHandler(this.btnMostQuest_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cmbErrorDescript
            // 
            this.cmbErrorDescript.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbErrorDescript.FormattingEnabled = true;
            this.cmbErrorDescript.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbErrorDescript.Location = new System.Drawing.Point(387, 34);
            this.cmbErrorDescript.MaxDropDownItems = 10;
            this.cmbErrorDescript.Name = "cmbErrorDescript";
            this.cmbErrorDescript.Size = new System.Drawing.Size(383, 21);
            this.cmbErrorDescript.TabIndex = 4;
            // 
            // btnProgSameLangReport
            // 
            this.btnProgSameLangReport.Location = new System.Drawing.Point(387, 12);
            this.btnProgSameLangReport.Name = "btnProgSameLangReport";
            this.btnProgSameLangReport.Size = new System.Drawing.Size(101, 21);
            this.btnProgSameLangReport.TabIndex = 5;
            this.btnProgSameLangReport.Text = "Generate Report";
            this.btnProgSameLangReport.UseVisualStyleBackColor = true;
            this.btnProgSameLangReport.Click += new System.EventHandler(this.btnProgSameLangReport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(494, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Shows what errors occur in different Languages";
            // 
            // frmProgLangReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbProgLangReport);
            this.Controls.Add(this.dgvProgLangReport);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmProgLangReports";
            this.Text = "Program Language Reports";
            this.Load += new System.EventHandler(this.frmProgLangReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgLangReport)).EndInit();
            this.gpbProgLangReport.ResumeLayout(false);
            this.gpbProgLangReport.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProgLangReport;
        private System.Windows.Forms.GroupBox gpbProgLangReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostQuest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProgLeastAnswered;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProgSameLangReport;
        private System.Windows.Forms.ComboBox cmbErrorDescript;
    }
}