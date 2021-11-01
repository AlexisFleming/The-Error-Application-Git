
namespace The_Error_Application
{
    partial class frmUser
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbAdminReport = new System.Windows.Forms.GroupBox();
            this.btnReportHelp = new System.Windows.Forms.Button();
            this.btnStudReport = new System.Windows.Forms.Button();
            this.btnLectReport = new System.Windows.Forms.Button();
            this.btnStudentSort = new System.Windows.Forms.Button();
            this.btnLectureSort = new System.Windows.Forms.Button();
            this.btnAdminSort = new System.Windows.Forms.Button();
            this.btnDiplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gpbAdminReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(304, 162);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(220, 162);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(138, 162);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(8, 214);
            this.dgvAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.RowHeadersWidth = 51;
            this.dgvAdmin.RowTemplate.Height = 24;
            this.dgvAdmin.Size = new System.Drawing.Size(802, 139);
            this.dgvAdmin.TabIndex = 9;
            this.dgvAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellClick);
            this.dgvAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellContentClick);
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(264, 109);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(161, 21);
            this.cmbRole.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(264, 82);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(161, 23);
            this.txtPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(264, 59);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Role ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Password:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(264, 37);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(161, 23);
            this.txtLastName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(264, 14);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(161, 23);
            this.txtFirstName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "User Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.logOutToolStripMenuItem.Text = "Exit";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // gpbAdminReport
            // 
            this.gpbAdminReport.Controls.Add(this.btnReportHelp);
            this.gpbAdminReport.Controls.Add(this.btnStudReport);
            this.gpbAdminReport.Controls.Add(this.btnLectReport);
            this.gpbAdminReport.Controls.Add(this.btnStudentSort);
            this.gpbAdminReport.Controls.Add(this.btnLectureSort);
            this.gpbAdminReport.Controls.Add(this.btnAdminSort);
            this.gpbAdminReport.Location = new System.Drawing.Point(514, 18);
            this.gpbAdminReport.Margin = new System.Windows.Forms.Padding(4);
            this.gpbAdminReport.Name = "gpbAdminReport";
            this.gpbAdminReport.Padding = new System.Windows.Forms.Padding(4);
            this.gpbAdminReport.Size = new System.Drawing.Size(296, 130);
            this.gpbAdminReport.TabIndex = 41;
            this.gpbAdminReport.TabStop = false;
            this.gpbAdminReport.Text = "Reports";
            // 
            // btnReportHelp
            // 
            this.btnReportHelp.Location = new System.Drawing.Point(139, 23);
            this.btnReportHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportHelp.Name = "btnReportHelp";
            this.btnReportHelp.Size = new System.Drawing.Size(111, 23);
            this.btnReportHelp.TabIndex = 42;
            this.btnReportHelp.Text = "Report Help";
            this.btnReportHelp.UseVisualStyleBackColor = true;
            this.btnReportHelp.Click += new System.EventHandler(this.btnReportHelp_Click);
            // 
            // btnStudReport
            // 
            this.btnStudReport.Location = new System.Drawing.Point(139, 81);
            this.btnStudReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudReport.Name = "btnStudReport";
            this.btnStudReport.Size = new System.Drawing.Size(111, 23);
            this.btnStudReport.TabIndex = 43;
            this.btnStudReport.Text = "Get Student Report";
            this.btnStudReport.UseVisualStyleBackColor = true;
            this.btnStudReport.Click += new System.EventHandler(this.btnStudReport_Click);
            // 
            // btnLectReport
            // 
            this.btnLectReport.Location = new System.Drawing.Point(139, 52);
            this.btnLectReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnLectReport.Name = "btnLectReport";
            this.btnLectReport.Size = new System.Drawing.Size(111, 23);
            this.btnLectReport.TabIndex = 42;
            this.btnLectReport.Text = "Get Lecturer Report";
            this.btnLectReport.UseVisualStyleBackColor = true;
            this.btnLectReport.Click += new System.EventHandler(this.btnLectReport_Click);
            // 
            // btnStudentSort
            // 
            this.btnStudentSort.Location = new System.Drawing.Point(30, 81);
            this.btnStudentSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudentSort.Name = "btnStudentSort";
            this.btnStudentSort.Size = new System.Drawing.Size(75, 23);
            this.btnStudentSort.TabIndex = 2;
            this.btnStudentSort.Text = "Students";
            this.btnStudentSort.UseVisualStyleBackColor = true;
            this.btnStudentSort.Click += new System.EventHandler(this.btnStudentSort_Click);
            // 
            // btnLectureSort
            // 
            this.btnLectureSort.Location = new System.Drawing.Point(30, 52);
            this.btnLectureSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnLectureSort.Name = "btnLectureSort";
            this.btnLectureSort.Size = new System.Drawing.Size(75, 23);
            this.btnLectureSort.TabIndex = 1;
            this.btnLectureSort.Text = "Lecturers";
            this.btnLectureSort.UseVisualStyleBackColor = true;
            this.btnLectureSort.Click += new System.EventHandler(this.btnLectureSort_Click);
            // 
            // btnAdminSort
            // 
            this.btnAdminSort.Location = new System.Drawing.Point(30, 23);
            this.btnAdminSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminSort.Name = "btnAdminSort";
            this.btnAdminSort.Size = new System.Drawing.Size(75, 23);
            this.btnAdminSort.TabIndex = 0;
            this.btnAdminSort.Text = "Admins";
            this.btnAdminSort.UseVisualStyleBackColor = true;
            this.btnAdminSort.Click += new System.EventHandler(this.btnAdminSort_Click);
            // 
            // btnDiplay
            // 
            this.btnDiplay.Location = new System.Drawing.Point(389, 162);
            this.btnDiplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiplay.Name = "btnDiplay";
            this.btnDiplay.Size = new System.Drawing.Size(75, 23);
            this.btnDiplay.TabIndex = 3;
            this.btnDiplay.Text = "Refresh";
            this.btnDiplay.UseVisualStyleBackColor = true;
            this.btnDiplay.Click += new System.EventHandler(this.btnDiplay_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 366);
            this.Controls.Add(this.btnDiplay);
            this.Controls.Add(this.gpbAdminReport);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAdmin);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUser";
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbAdminReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpbAdminReport;
        private System.Windows.Forms.Button btnReportHelp;
        private System.Windows.Forms.Button btnStudReport;
        private System.Windows.Forms.Button btnLectReport;
        private System.Windows.Forms.Button btnStudentSort;
        private System.Windows.Forms.Button btnLectureSort;
        private System.Windows.Forms.Button btnAdminSort;
        private System.Windows.Forms.Button btnDiplay;
    }
}