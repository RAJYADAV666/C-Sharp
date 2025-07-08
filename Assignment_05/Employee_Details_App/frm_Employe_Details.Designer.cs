
namespace Employee_Details_App
{
    partial class frm_Employe_Details
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
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Empolye_Name = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Shift = new System.Windows.Forms.Label();
            this.lbl_Employee_Dep = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.Cmb_Details = new System.Windows.Forms.ComboBox();
            this.rdb_Male = new System.Windows.Forms.RadioButton();
            this.rdb_Female = new System.Windows.Forms.RadioButton();
            this.rdb_Morning = new System.Windows.Forms.RadioButton();
            this.rdb_Evening = new System.Windows.Forms.RadioButton();
            this.rdb_Night = new System.Windows.Forms.RadioButton();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.pnl_Output = new System.Windows.Forms.Panel();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.grp_Gender = new System.Windows.Forms.GroupBox();
            this.grp_Shift = new System.Windows.Forms.GroupBox();
            this.pnl_Output.SuspendLayout();
            this.grp_Gender.SuspendLayout();
            this.grp_Shift.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Mongolian Baiti", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Header.Location = new System.Drawing.Point(319, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(609, 85);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Employee Details";
            // 
            // lbl_Empolye_Name
            // 
            this.lbl_Empolye_Name.AutoSize = true;
            this.lbl_Empolye_Name.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Empolye_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Empolye_Name.Location = new System.Drawing.Point(42, 161);
            this.lbl_Empolye_Name.Name = "lbl_Empolye_Name";
            this.lbl_Empolye_Name.Size = new System.Drawing.Size(239, 35);
            this.lbl_Empolye_Name.TabIndex = 1;
            this.lbl_Empolye_Name.Text = "Employee Name";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Gender.Location = new System.Drawing.Point(42, 364);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(114, 35);
            this.lbl_Gender.TabIndex = 2;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Shift
            // 
            this.lbl_Shift.AutoSize = true;
            this.lbl_Shift.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shift.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Shift.Location = new System.Drawing.Point(42, 468);
            this.lbl_Shift.Name = "lbl_Shift";
            this.lbl_Shift.Size = new System.Drawing.Size(157, 35);
            this.lbl_Shift.TabIndex = 3;
            this.lbl_Shift.Text = "Shift Time";
            // 
            // lbl_Employee_Dep
            // 
            this.lbl_Employee_Dep.AutoSize = true;
            this.lbl_Employee_Dep.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Dep.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Employee_Dep.Location = new System.Drawing.Point(42, 270);
            this.lbl_Employee_Dep.Name = "lbl_Employee_Dep";
            this.lbl_Employee_Dep.Size = new System.Drawing.Size(317, 35);
            this.lbl_Employee_Dep.TabIndex = 4;
            this.lbl_Employee_Dep.Text = "Employee Department";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Reset.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Blue;
            this.btn_Reset.Location = new System.Drawing.Point(398, 578);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(141, 50);
            this.btn_Reset.TabIndex = 6;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Output.Location = new System.Drawing.Point(42, 686);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(108, 35);
            this.lbl_Output.TabIndex = 6;
            this.lbl_Output.Text = "Output";
            // 
            // tb_Name
            // 
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Name.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(528, 155);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(663, 42);
            this.tb_Name.TabIndex = 7;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // Cmb_Details
            // 
            this.Cmb_Details.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Details.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Details.FormattingEnabled = true;
            this.Cmb_Details.Items.AddRange(new object[] {
            "R&D",
            "Manager",
            "Developer"});
            this.Cmb_Details.Location = new System.Drawing.Point(528, 267);
            this.Cmb_Details.Name = "Cmb_Details";
            this.Cmb_Details.Size = new System.Drawing.Size(284, 39);
            this.Cmb_Details.TabIndex = 8;
            // 
            // rdb_Male
            // 
            this.rdb_Male.AutoSize = true;
            this.rdb_Male.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Male.ForeColor = System.Drawing.Color.Black;
            this.rdb_Male.Location = new System.Drawing.Point(50, 30);
            this.rdb_Male.Name = "rdb_Male";
            this.rdb_Male.Size = new System.Drawing.Size(82, 29);
            this.rdb_Male.TabIndex = 9;
            this.rdb_Male.TabStop = true;
            this.rdb_Male.Text = "Male";
            this.rdb_Male.UseVisualStyleBackColor = true;
            // 
            // rdb_Female
            // 
            this.rdb_Female.AutoSize = true;
            this.rdb_Female.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Female.ForeColor = System.Drawing.Color.Black;
            this.rdb_Female.Location = new System.Drawing.Point(309, 24);
            this.rdb_Female.Name = "rdb_Female";
            this.rdb_Female.Size = new System.Drawing.Size(103, 29);
            this.rdb_Female.TabIndex = 10;
            this.rdb_Female.TabStop = true;
            this.rdb_Female.Text = "Female";
            this.rdb_Female.UseVisualStyleBackColor = true;
            // 
            // rdb_Morning
            // 
            this.rdb_Morning.AutoSize = true;
            this.rdb_Morning.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Morning.ForeColor = System.Drawing.Color.Black;
            this.rdb_Morning.Location = new System.Drawing.Point(50, 24);
            this.rdb_Morning.Name = "rdb_Morning";
            this.rdb_Morning.Size = new System.Drawing.Size(116, 29);
            this.rdb_Morning.TabIndex = 11;
            this.rdb_Morning.TabStop = true;
            this.rdb_Morning.Text = "Morning";
            this.rdb_Morning.UseVisualStyleBackColor = true;
            // 
            // rdb_Evening
            // 
            this.rdb_Evening.AutoSize = true;
            this.rdb_Evening.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Evening.ForeColor = System.Drawing.Color.Black;
            this.rdb_Evening.Location = new System.Drawing.Point(311, 24);
            this.rdb_Evening.Name = "rdb_Evening";
            this.rdb_Evening.Size = new System.Drawing.Size(113, 29);
            this.rdb_Evening.TabIndex = 12;
            this.rdb_Evening.TabStop = true;
            this.rdb_Evening.Text = "Evening";
            this.rdb_Evening.UseVisualStyleBackColor = true;
            // 
            // rdb_Night
            // 
            this.rdb_Night.AutoSize = true;
            this.rdb_Night.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Night.ForeColor = System.Drawing.Color.Black;
            this.rdb_Night.Location = new System.Drawing.Point(547, 24);
            this.rdb_Night.Name = "rdb_Night";
            this.rdb_Night.Size = new System.Drawing.Size(87, 29);
            this.rdb_Night.TabIndex = 13;
            this.rdb_Night.TabStop = true;
            this.rdb_Night.Text = "Night";
            this.rdb_Night.UseVisualStyleBackColor = true;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Submit.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Submit.Location = new System.Drawing.Point(741, 578);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(141, 50);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // pnl_Output
            // 
            this.pnl_Output.Controls.Add(this.tb_Output);
            this.pnl_Output.Location = new System.Drawing.Point(204, 680);
            this.pnl_Output.Name = "pnl_Output";
            this.pnl_Output.Size = new System.Drawing.Size(1007, 41);
            this.pnl_Output.TabIndex = 15;
            // 
            // tb_Output
            // 
            this.tb_Output.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Output.Location = new System.Drawing.Point(-7, 0);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.Size = new System.Drawing.Size(1014, 39);
            this.tb_Output.TabIndex = 16;
            // 
            // grp_Gender
            // 
            this.grp_Gender.BackColor = System.Drawing.Color.Cornsilk;
            this.grp_Gender.Controls.Add(this.rdb_Male);
            this.grp_Gender.Controls.Add(this.rdb_Female);
            this.grp_Gender.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Gender.ForeColor = System.Drawing.Color.Crimson;
            this.grp_Gender.Location = new System.Drawing.Point(516, 339);
            this.grp_Gender.Name = "grp_Gender";
            this.grp_Gender.Size = new System.Drawing.Size(524, 84);
            this.grp_Gender.TabIndex = 3;
            this.grp_Gender.TabStop = false;
            this.grp_Gender.Text = "Gender";
            // 
            // grp_Shift
            // 
            this.grp_Shift.BackColor = System.Drawing.Color.Cornsilk;
            this.grp_Shift.Controls.Add(this.rdb_Morning);
            this.grp_Shift.Controls.Add(this.rdb_Night);
            this.grp_Shift.Controls.Add(this.rdb_Evening);
            this.grp_Shift.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Shift.ForeColor = System.Drawing.Color.Crimson;
            this.grp_Shift.Location = new System.Drawing.Point(516, 444);
            this.grp_Shift.Name = "grp_Shift";
            this.grp_Shift.Size = new System.Drawing.Size(703, 81);
            this.grp_Shift.TabIndex = 4;
            this.grp_Shift.TabStop = false;
            this.grp_Shift.Text = "Shift Time";
            // 
            // frm_Employe_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 756);
            this.Controls.Add(this.grp_Shift);
            this.Controls.Add(this.grp_Gender);
            this.Controls.Add(this.pnl_Output);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.Cmb_Details);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lbl_Employee_Dep);
            this.Controls.Add(this.lbl_Shift);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Empolye_Name);
            this.Controls.Add(this.lbl_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Employe_Details";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.frm_Employe_Details_Load);
            this.pnl_Output.ResumeLayout(false);
            this.pnl_Output.PerformLayout();
            this.grp_Gender.ResumeLayout(false);
            this.grp_Gender.PerformLayout();
            this.grp_Shift.ResumeLayout(false);
            this.grp_Shift.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Empolye_Name;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Shift;
        private System.Windows.Forms.Label lbl_Employee_Dep;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.ComboBox Cmb_Details;
        private System.Windows.Forms.RadioButton rdb_Male;
        private System.Windows.Forms.RadioButton rdb_Female;
        private System.Windows.Forms.RadioButton rdb_Morning;
        private System.Windows.Forms.RadioButton rdb_Evening;
        private System.Windows.Forms.RadioButton rdb_Night;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Panel pnl_Output;
        private System.Windows.Forms.TextBox tb_Output;
        private System.Windows.Forms.GroupBox grp_Gender;
        private System.Windows.Forms.GroupBox grp_Shift;
    }
}

