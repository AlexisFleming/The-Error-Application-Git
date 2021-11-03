
namespace The_Error_Application
{
    partial class FrmErrorReport
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
            this.StudentInfo = new System.Windows.Forms.DataGridView();
            this.LecturerInfo = new System.Windows.Forms.DataGridView();
            this.txtErrorID = new System.Windows.Forms.TextBox();
            this.txtSolutionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentInfo
            // 
            this.StudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentInfo.Location = new System.Drawing.Point(12, 204);
            this.StudentInfo.Name = "StudentInfo";
            this.StudentInfo.Size = new System.Drawing.Size(502, 234);
            this.StudentInfo.TabIndex = 0;
            this.StudentInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LecturerInfo
            // 
            this.LecturerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LecturerInfo.Location = new System.Drawing.Point(721, 204);
            this.LecturerInfo.Name = "LecturerInfo";
            this.LecturerInfo.Size = new System.Drawing.Size(502, 234);
            this.LecturerInfo.TabIndex = 1;
            // 
            // txtErrorID
            // 
            this.txtErrorID.Location = new System.Drawing.Point(100, 125);
            this.txtErrorID.Name = "txtErrorID";
            this.txtErrorID.Size = new System.Drawing.Size(100, 20);
            this.txtErrorID.TabIndex = 2;
            // 
            // txtSolutionID
            // 
            this.txtSolutionID.Location = new System.Drawing.Point(846, 125);
            this.txtSolutionID.Name = "txtSolutionID";
            this.txtSolutionID.Size = new System.Drawing.Size(100, 20);
            this.txtSolutionID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "StudentID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(718, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "LecturerID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(721, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "Display";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmErrorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSolutionID);
            this.Controls.Add(this.txtErrorID);
            this.Controls.Add(this.LecturerInfo);
            this.Controls.Add(this.StudentInfo);
            this.Name = "FrmErrorReport";
            this.Text = "FrmErrorReport";
            this.Load += new System.EventHandler(this.FrmErrorReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentInfo;
        private System.Windows.Forms.DataGridView LecturerInfo;
        private System.Windows.Forms.TextBox txtErrorID;
        private System.Windows.Forms.TextBox txtSolutionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}