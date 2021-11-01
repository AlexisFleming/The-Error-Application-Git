
namespace The_Error_Application
{
    partial class frmAdminHub
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
            this.btnToUsers = new System.Windows.Forms.Button();
            this.btnProgLang = new System.Windows.Forms.Button();
            this.btnToRole = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnToYear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToUsers
            // 
            this.btnToUsers.Location = new System.Drawing.Point(401, 152);
            this.btnToUsers.Name = "btnToUsers";
            this.btnToUsers.Size = new System.Drawing.Size(102, 23);
            this.btnToUsers.TabIndex = 0;
            this.btnToUsers.Text = "Manage Users";
            this.btnToUsers.UseVisualStyleBackColor = true;
            this.btnToUsers.Click += new System.EventHandler(this.btnToUsers_Click);
            // 
            // btnProgLang
            // 
            this.btnProgLang.Location = new System.Drawing.Point(193, 152);
            this.btnProgLang.Name = "btnProgLang";
            this.btnProgLang.Size = new System.Drawing.Size(187, 23);
            this.btnProgLang.TabIndex = 1;
            this.btnProgLang.Text = "Manage Programming Languages";
            this.btnProgLang.UseVisualStyleBackColor = true;
            this.btnProgLang.Click += new System.EventHandler(this.btnProgLang_Click);
            // 
            // btnToRole
            // 
            this.btnToRole.Location = new System.Drawing.Point(63, 152);
            this.btnToRole.Name = "btnToRole";
            this.btnToRole.Size = new System.Drawing.Size(96, 23);
            this.btnToRole.TabIndex = 2;
            this.btnToRole.Text = "Manage Roles";
            this.btnToRole.UseVisualStyleBackColor = true;
            this.btnToRole.Click += new System.EventHandler(this.btnToRole_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnToYear
            // 
            this.btnToYear.Location = new System.Drawing.Point(254, 208);
            this.btnToYear.Name = "btnToYear";
            this.btnToYear.Size = new System.Drawing.Size(97, 23);
            this.btnToYear.TabIndex = 4;
            this.btnToYear.Text = "Manage Years";
            this.btnToYear.UseVisualStyleBackColor = true;
            this.btnToYear.Click += new System.EventHandler(this.btnToYear_Click);
            // 
            // frmAdminHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 419);
            this.Controls.Add(this.btnToYear);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnToRole);
            this.Controls.Add(this.btnProgLang);
            this.Controls.Add(this.btnToUsers);
            this.Name = "frmAdminHub";
            this.Text = "frmAdminHub";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToUsers;
        private System.Windows.Forms.Button btnProgLang;
        private System.Windows.Forms.Button btnToRole;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnToYear;
    }
}