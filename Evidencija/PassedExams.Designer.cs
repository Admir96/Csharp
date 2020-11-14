namespace Evidencija
{
    partial class PassedExams
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
            this.dgvExams = new System.Windows.Forms.DataGridView();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.cmbExams = new System.Windows.Forms.ComboBox();
            this.dtpForExam = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExams
            // 
            this.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.ExamName,
            this.Grade,
            this.Date});
            this.dgvExams.Location = new System.Drawing.Point(12, 44);
            this.dgvExams.Name = "dgvExams";
            this.dgvExams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExams.Size = new System.Drawing.Size(545, 150);
            this.dgvExams.TabIndex = 0;
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentName.DataPropertyName = "Student";
            this.StudentName.HeaderText = "Student Name:";
            this.StudentName.Name = "StudentName";
            // 
            // ExamName
            // 
            this.ExamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExamName.DataPropertyName = "Exam";
            this.ExamName.HeaderText = "Exam Name:";
            this.ExamName.Name = "ExamName";
            // 
            // Grade
            // 
            this.Grade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Grade.DataPropertyName = "Grade";
            this.Grade.HeaderText = "Grade:";
            this.Grade.Name = "Grade";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date:";
            this.Date.Name = "Date";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(153, 20);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(97, 20);
            this.txtGrade.TabIndex = 1;
            // 
            // cmbExams
            // 
            this.cmbExams.FormattingEnabled = true;
            this.cmbExams.Location = new System.Drawing.Point(13, 20);
            this.cmbExams.Name = "cmbExams";
            this.cmbExams.Size = new System.Drawing.Size(134, 21);
            this.cmbExams.TabIndex = 2;
            // 
            // dtpForExam
            // 
            this.dtpForExam.Location = new System.Drawing.Point(256, 20);
            this.dtpForExam.Name = "dtpForExam";
            this.dtpForExam.Size = new System.Drawing.Size(200, 20);
            this.dtpForExam.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(462, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Exam";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // PassedExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 207);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpForExam);
            this.Controls.Add(this.cmbExams);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.dgvExams);
            this.Name = "PassedExams";
            this.Text = "PassedExams";
            this.Load += new System.EventHandler(this.PassedExams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExams;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.ComboBox cmbExams;
        private System.Windows.Forms.DateTimePicker dtpForExam;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}