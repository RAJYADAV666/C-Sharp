using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sgm_College_Admission_App
{
    public partial class frm_Add_New_Student_Details : Form
    {
        public frm_Add_New_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection FCon = new SqlConnection(@"Data Source=DESKTOP-D15T778;Initial Catalog=Sgm_Admission_Systeam_DB;Integrated Security=True");

        void FCon_Start()
        {
            if(FCon.State != ConnectionState.Open)
            {
                FCon.Open();
            }
        }
        void FCon_Stop()
        {
            if(FCon.State != ConnectionState.Closed)
            {
                FCon.Close();
            }
        }

        void Clear_Controls()
        {
            tb_RollNo.Clear();
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            cmb_Course.SelectedIndex = -1;

            dtp_DOB.Text = "01-02-2001";
            
        }
        private void Only_Number(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void frm_Add_New_Student_Details_Load(object sender, EventArgs e)
        {
            lbl_UserName.Text = "Welcome " + Shared_Content.Uname;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            FCon_Start();

            if (tb_RollNo.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && cmb_Course.SelectedIndex >= 0)
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.CommandText = "Insert Into Student_Details(Roll_No,Name,Mobile_No,DOB,Course)Values(@RNo, @Nm, @MNo, @Db, @Course)";
                Cmd.Connection = FCon;

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_RollNo.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("MNO", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Db", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Student Details Saved Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill all Field", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Search_Student_Click(object sender, EventArgs e)
        {
            frm_Search obj = new frm_Search();
            obj.Show();
            this.Hide();
        }

        private void btn_StudentList_Click(object sender, EventArgs e)
        {
            frm_Student_Details obj = new frm_Student_Details();
            obj.Show();
            this.Hide();
        }
       
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }
    }
}
