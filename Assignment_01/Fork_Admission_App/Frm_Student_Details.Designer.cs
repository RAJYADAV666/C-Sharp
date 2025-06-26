
namespace Fork_Admission_App
{
    partial class Frm_Student_Details
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Heder = new System.Windows.Forms.Label();
            this.dgv_StudentDetails = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fork_Admission_Systeam_DBDataSet1 = new Fork_Admission_App.Fork_Admission_Systeam_DBDataSet1();
            this.lbl_Add_New_Student = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.fork_Admission_Systeam_DBDataSet = new Fork_Admission_App.Fork_Admission_Systeam_DBDataSet();
            this.forkAdmissionSysteamDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_DetailsTableAdapter = new Fork_Admission_App.Fork_Admission_Systeam_DBDataSet1TableAdapters.Student_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Admission_Systeam_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Admission_Systeam_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forkAdmissionSysteamDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Heder
            // 
            this.lbl_Heder.AutoSize = true;
            this.lbl_Heder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Heder.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Heder.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Heder.Location = new System.Drawing.Point(330, 33);
            this.lbl_Heder.Name = "lbl_Heder";
            this.lbl_Heder.Size = new System.Drawing.Size(321, 64);
            this.lbl_Heder.TabIndex = 0;
            this.lbl_Heder.Text = "Student List";
            // 
            // dgv_StudentDetails
            // 
            this.dgv_StudentDetails.AllowUserToAddRows = false;
            this.dgv_StudentDetails.AllowUserToDeleteRows = false;
            this.dgv_StudentDetails.AutoGenerateColumns = false;
            this.dgv_StudentDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_StudentDetails.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_StudentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StudentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_StudentDetails.DataSource = this.studentDetailsBindingSource;
            this.dgv_StudentDetails.Location = new System.Drawing.Point(1, 126);
            this.dgv_StudentDetails.Name = "dgv_StudentDetails";
            this.dgv_StudentDetails.ReadOnly = true;
            this.dgv_StudentDetails.RowHeadersWidth = 51;
            this.dgv_StudentDetails.RowTemplate.Height = 24;
            this.dgv_StudentDetails.Size = new System.Drawing.Size(1139, 465);
            this.dgv_StudentDetails.TabIndex = 1;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this.fork_Admission_Systeam_DBDataSet1;
            // 
            // fork_Admission_Systeam_DBDataSet1
            // 
            this.fork_Admission_Systeam_DBDataSet1.DataSetName = "Fork_Admission_Systeam_DBDataSet1";
            this.fork_Admission_Systeam_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_Add_New_Student
            // 
            this.lbl_Add_New_Student.AutoSize = true;
            this.lbl_Add_New_Student.BackColor = System.Drawing.Color.White;
            this.lbl_Add_New_Student.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Student.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_Add_New_Student.Location = new System.Drawing.Point(391, 632);
            this.lbl_Add_New_Student.Name = "lbl_Add_New_Student";
            this.lbl_Add_New_Student.Size = new System.Drawing.Size(254, 35);
            this.lbl_Add_New_Student.TabIndex = 2;
            this.lbl_Add_New_Student.Text = "Add New Student";
            this.lbl_Add_New_Student.Click += new System.EventHandler(this.lbl_Add_New_Student_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Logout.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Red;
            this.btn_Logout.Location = new System.Drawing.Point(993, 2);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(147, 50);
            this.btn_Logout.TabIndex = 10;
            this.btn_Logout.Text = "Log Out";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // fork_Admission_Systeam_DBDataSet
            // 
            this.fork_Admission_Systeam_DBDataSet.DataSetName = "Fork_Admission_Systeam_DBDataSet";
            this.fork_Admission_Systeam_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // forkAdmissionSysteamDBDataSetBindingSource
            // 
            this.forkAdmissionSysteamDBDataSetBindingSource.DataSource = this.fork_Admission_Systeam_DBDataSet;
            this.forkAdmissionSysteamDBDataSetBindingSource.Position = 0;
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 707);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_Add_New_Student);
            this.Controls.Add(this.dgv_StudentDetails);
            this.Controls.Add(this.lbl_Heder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Student_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.Frm_Student_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Admission_Systeam_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Admission_Systeam_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forkAdmissionSysteamDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Heder;
        private System.Windows.Forms.DataGridView dgv_StudentDetails;
        private System.Windows.Forms.Label lbl_Add_New_Student;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.BindingSource forkAdmissionSysteamDBDataSetBindingSource;
        private Fork_Admission_Systeam_DBDataSet fork_Admission_Systeam_DBDataSet;
        private Fork_Admission_Systeam_DBDataSet1 fork_Admission_Systeam_DBDataSet1;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private Fork_Admission_Systeam_DBDataSet1TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}