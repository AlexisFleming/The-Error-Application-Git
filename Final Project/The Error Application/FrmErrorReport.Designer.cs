
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
            this.dgvError = new System.Windows.Forms.DataGridView();
            this.dgvSolution = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentIDdisp = new System.Windows.Forms.Button();
            this.LecturerIDdisp = new System.Windows.Forms.Button();
            this.StudentIDcmb = new System.Windows.Forms.ComboBox();
            this.lecturerIDcmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolution)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvError
            // 
            this.dgvError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvError.Location = new System.Drawing.Point(12, 204);
            this.dgvError.Name = "dgvError";
            this.dgvError.Size = new System.Drawing.Size(502, 234);
            this.dgvError.TabIndex = 0;
            this.dgvError.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvSolution
            // 
            this.dgvSolution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolution.Location = new System.Drawing.Point(721, 204);
            this.dgvSolution.Name = "dgvSolution";
            this.dgvSolution.Size = new System.Drawing.Size(502, 234);
            this.dgvSolution.TabIndex = 1;
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
            // StudentIDdisp
            // 
            this.StudentIDdisp.Location = new System.Drawing.Point(12, 168);
            this.StudentIDdisp.Name = "StudentIDdisp";
            this.StudentIDdisp.Size = new System.Drawing.Size(51, 30);
            this.StudentIDdisp.TabIndex = 6;
            this.StudentIDdisp.Text = "Display";
            this.StudentIDdisp.UseVisualStyleBackColor = true;
            this.StudentIDdisp.Click += new System.EventHandler(this.button1_Click);
            // 
            // LecturerIDdisp
            // 
            this.LecturerIDdisp.Location = new System.Drawing.Point(721, 168);
            this.LecturerIDdisp.Name = "LecturerIDdisp";
            this.LecturerIDdisp.Size = new System.Drawing.Size(51, 30);
            this.LecturerIDdisp.TabIndex = 7;
            this.LecturerIDdisp.Text = "Display";
            this.LecturerIDdisp.UseVisualStyleBackColor = true;
            this.LecturerIDdisp.Click += new System.EventHandler(this.button2_Click);
            // 
            // StudentIDcmb
            // 
            this.StudentIDcmb.FormattingEnabled = true;
            this.StudentIDcmb.Location = new System.Drawing.Point(133, 123);
            this.StudentIDcmb.Name = "StudentIDcmb";
            this.StudentIDcmb.Size = new System.Drawing.Size(156, 21);
            this.StudentIDcmb.TabIndex = 8;
            this.StudentIDcmb.SelectedIndexChanged += new System.EventHandler(this.StudentIDcmb_SelectedIndexChanged);
            // 
            // lecturerIDcmb
            // 
            this.lecturerIDcmb.FormattingEnabled = true;
            this.lecturerIDcmb.Location = new System.Drawing.Point(879, 123);
            this.lecturerIDcmb.Name = "lecturerIDcmb";
            this.lecturerIDcmb.Size = new System.Drawing.Size(121, 21);
            this.lecturerIDcmb.TabIndex = 9;
            // 
            // FrmErrorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 450);
            this.Controls.Add(this.lecturerIDcmb);
            this.Controls.Add(this.StudentIDcmb);
            this.Controls.Add(this.LecturerIDdisp);
            this.Controls.Add(this.StudentIDdisp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSolution);
            this.Controls.Add(this.dgvError);
            this.Name = "FrmErrorReport";
            this.Text = "FrmErrorReport";
            this.Load += new System.EventHandler(this.FrmErrorReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvError;
        private System.Windows.Forms.DataGridView dgvSolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StudentIDdisp;
        private System.Windows.Forms.Button LecturerIDdisp;
        private System.Windows.Forms.ComboBox StudentIDcmb;
        private System.Windows.Forms.ComboBox lecturerIDcmb;
    }
}