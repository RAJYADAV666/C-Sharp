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

namespace Yadav_College_Admission_App
{
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
        }

        SqlConnection FCon = new SqlConnection(@"Data Source=DESKTOP-D15T778;Initial Catalog=Yadav_Admission_Systeam_DB;Integrated Security=True");

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

        void Clear_Control()
        {
            tb_RollNo.Clear();
            tb_Name.Clear();
            tb_MobileNo.Clear();
            cmb_Course.SelectedIndex = -1;

            dtp_DOB.Text = "01-02-2002";
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (Char)Keys.Back)))
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            FCon_Start();

            if(tb_RollNo.Text != "" && tb_Name.Text != "" && tb_MobileNo.Text != "" && cmb_Course.SelectedIndex >= 0 )
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Insert Into Student_Details Values(@RNo, @Nm, @Db, @MNo, @Course)";
                cmd.Connection = FCon;

                cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_RollNo.Text;
                cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("Db", SqlDbType.Date).Value = dtp_DOB.Text;
                cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_MobileNo.Text;
                cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show(" Student Details Saved Succesfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Control();
            }
            else
            {
                MessageBox.Show("Filled Information", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frm_Add_New_Student_Load(object sender, EventArgs e)
        {
            lbl_UserName.Text = Shared_Content.UserName;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }
      
        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_List obj = new frm_Student_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            frm_Student_Search obj = new frm_Student_Search();
            obj.Show();
            this.Hide();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            frm_Student_Update obj = new frm_Student_Update();
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
