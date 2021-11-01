
namespace The_Error_Application
{
    partial class frmLecturerHub
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
            this.btnToTopic = new System.Windows.Forms.Button();
            this.btnToSol = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAssignSol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToTopic
            // 
            this.btnToTopic.Location = new System.Drawing.Point(470, 188);
            this.btnToTopic.Name = "btnToTopic";
            this.btnToTopic.Size = new System.Drawing.Size(102, 23);
            this.btnToTopic.TabIndex = 0;
            this.btnToTopic.Text = "Manage Topics";
            this.btnToTopic.UseVisualStyleBackColor = true;
            this.btnToTopic.Click += new System.EventHandler(this.btnToTopic_Click);
            // 
            // btnToSol
            // 
            this.btnToSol.Location = new System.Drawing.Point(238, 188);
            this.btnToSol.Name = "btnToSol";
            this.btnToSol.Size = new System.Drawing.Size(125, 23);
            this.btnToSol.TabIndex = 1;
            this.btnToSol.Text = "Manage Solutions";
            this.btnToSol.UseVisualStyleBackColor = true;
            this.btnToSol.Click += new System.EventHandler(this.btnToSol_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAssignSol
            // 
            this.btnAssignSol.Location = new System.Drawing.Point(85, 180);
            this.btnAssignSol.Name = "btnAssignSol";
            this.btnAssignSol.Size = new System.Drawing.Size(100, 38);
            this.btnAssignSol.TabIndex = 3;
            this.btnAssignSol.Text = "Assign Solutions to Errors";
            this.btnAssignSol.UseVisualStyleBackColor = true;
            this.btnAssignSol.Click += new System.EventHandler(this.btnAssignSol_Click);
            // 
            // frmLecturerHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAssignSol);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnToSol);
            this.Controls.Add(this.btnToTopic);
            this.Name = "frmLecturerHub";
            this.Text = "frmLecturerHub";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToTopic;
        private System.Windows.Forms.Button btnToSol;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAssignSol;
    }
}