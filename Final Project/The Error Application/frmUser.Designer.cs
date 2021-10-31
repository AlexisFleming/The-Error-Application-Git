
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progammingModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDiplay = new System.Windows.Forms.Button();
            this.gpbAdminReport = new System.Windows.Forms.GroupBox();
            this.btnReportHelp = new System.Windows.Forms.Button();
            this.btnStudReport = new System.Windows.Forms.Button();
            this.btnLectReport = new System.Windows.Forms.Button();
            this.btnStudentSort = new System.Windows.Forms.Button();
            this.btnLectureSort = new System.Windows.Forms.Button();
            this.btnAdminSort = new System.Windows.Forms.Button();
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
            this.menuStrip1.SuspendLayout();
            this.gpbAdminReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 28);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progammingModulesToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // progammingModulesToolStripMenuItem
            // 
            this.progammingModulesToolStripMenuItem.Name = "progammingModulesToolStripMenuItem";
            this.progammingModulesToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.progammingModulesToolStripMenuItem.Text = "Progamming Modules";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.logOutToolStripMenuItem.Text = "Exit";
            // 
            // btnDiplay
            // 
            this.btnDiplay.Location = new System.Drawing.Point(430, 220);
            this.btnDiplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiplay.Name = "btnDiplay";
            this.btnDiplay.Size = new System.Drawing.Size(100, 28);
            this.btnDiplay.TabIndex = 8;
            this.btnDiplay.Text = "Refresh";
            this.btnDiplay.UseVisualStyleBackColor = true;
            // 
            // gpbAdminReport
            // 
            this.gpbAdminReport.Controls.Add(this.btnReportHelp);
            this.gpbAdminReport.Controls.Add(this.btnStudReport);
            this.gpbAdminReport.Controls.Add(this.btnLectReport);
            this.gpbAdminReport.Controls.Add(this.btnStudentSort);
            this.gpbAdminReport.Controls.Add(this.btnLectureSort);
            this.gpbAdminReport.Controls.Add(this.btnAdminSort);
            this.gpbAdminReport.Location = new System.Drawing.Point(596, 43);
            this.gpbAdminReport.Margin = new System.Windows.Forms.Padding(4);
            this.gpbAdminReport.Name = "gpbAdminReport";
            this.gpbAdminReport.Padding = new System.Windows.Forms.Padding(4);
            this.gpbAdminReport.Size = new System.Drawing.Size(395, 160);
            this.gpbAdminReport.TabIndex = 57;
            this.gpbAdminReport.TabStop = false;
            this.gpbAdminReport.Text = "Reports";
            // 
            // btnReportHelp
            // 
            this.btnReportHelp.Location = new System.Drawing.Point(185, 28);
            this.btnReportHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportHelp.Name = "btnReportHelp";
            this.btnReportHelp.Size = new System.Drawing.Size(148, 28);
            this.btnReportHelp.TabIndex = 13;
            this.btnReportHelp.Text = "Report Help";
            this.btnReportHelp.UseVisualStyleBackColor = true;
            // 
            // btnStudReport
            // 
            this.btnStudReport.Location = new System.Drawing.Point(185, 100);
            this.btnStudReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudReport.Name = "btnStudReport";
            this.btnStudReport.Size = new System.Drawing.Size(148, 28);
            this.btnStudReport.TabIndex = 15;
            this.btnStudReport.Text = "Get Student Report";
            this.btnStudReport.UseVisualStyleBackColor = true;
            // 
            // btnLectReport
            // 
            this.btnLectReport.Location = new System.Drawing.Point(185, 64);
            this.btnLectReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnLectReport.Name = "btnLectReport";
            this.btnLectReport.Size = new System.Drawing.Size(148, 28);
            this.btnLectReport.TabIndex = 14;
            this.btnLectReport.Text = "Get Lecturer Report";
            this.btnLectReport.UseVisualStyleBackColor = true;
            // 
            // btnStudentSort
            // 
            this.btnStudentSort.Location = new System.Drawing.Point(40, 100);
            this.btnStudentSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudentSort.Name = "btnStudentSort";
            this.btnStudentSort.Size = new System.Drawing.Size(100, 28);
            this.btnStudentSort.TabIndex = 12;
            this.btnStudentSort.Text = "Students";
            this.btnStudentSort.UseVisualStyleBackColor = true;
            // 
            // btnLectureSort
            // 
            this.btnLectureSort.Location = new System.Drawing.Point(40, 64);
            this.btnLectureSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnLectureSort.Name = "btnLectureSort";
            this.btnLectureSort.Size = new System.Drawing.Size(100, 28);
            this.btnLectureSort.TabIndex = 11;
            this.btnLectureSort.Text = "Lecturers";
            this.btnLectureSort.UseVisualStyleBackColor = true;
            // 
            // btnAdminSort
            // 
            this.btnAdminSort.Location = new System.Drawing.Point(40, 28);
            this.btnAdminSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminSort.Name = "btnAdminSort";
            this.btnAdminSort.Size = new System.Drawing.Size(100, 28);
            this.btnAdminSort.TabIndex = 10;
            this.btnAdminSort.Text = "Admins";
            this.btnAdminSort.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(316, 220);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 28);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(204, 220);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 28);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(95, 220);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 28);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(12, 293);
            this.dgvAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.RowHeadersWidth = 51;
            this.dgvAdmin.RowTemplate.Height = 24;
            this.dgvAdmin.Size = new System.Drawing.Size(979, 171);
            this.dgvAdmin.TabIndex = 9;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(263, 155);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(213, 24);
            this.cmbRole.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(263, 122);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(213, 27);
            this.txtPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(263, 94);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 27);
            this.txtEmail.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Role ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Password:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(263, 67);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(213, 27);
            this.txtLastName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(263, 38);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(213, 27);
            this.txtFirstName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "User Name:";
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 484);
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
            this.Name = "frmUser";
            this.Text = "frmUser";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbAdminReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progammingModulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button btnDiplay;
        private System.Windows.Forms.GroupBox gpbAdminReport;
        private System.Windows.Forms.Button btnReportHelp;
        private System.Windows.Forms.Button btnStudReport;
        private System.Windows.Forms.Button btnLectReport;
        private System.Windows.Forms.Button btnStudentSort;
        private System.Windows.Forms.Button btnLectureSort;
        private System.Windows.Forms.Button btnAdminSort;
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
    }
}