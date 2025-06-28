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
    public partial class frm_Search : Form
    {
        public frm_Search()
        {
            InitializeComponent();
        }

        SqlConnection FCon = new SqlConnection(@"Data Source=DESKTOP-D15T778;Initial Catalog=Sgm_Admission_Systeam_DB;Integrated Security=True");

        void FCon_Start()
        {
            if (FCon.State != ConnectionState.Open)
            {
                FCon.Open();
            }
        }
        void FCon_Stop()
        {
            if (FCon.State != ConnectionState.Closed)
            {
                FCon.Close();
            }
        }

        void Clear_Control()
        {
            tb_RollNo.Clear();
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            cmb_Course.SelectedIndex = -1;

            dtp_DOB.Text = "01 - 05 - 2025";
        }
        
        private void Only_Number(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void frm_Student_Search_Load(object sender, EventArgs e)
        {
            lbl_UserName.Text = "Welcome " + Shared_Content.Uname;
            tb_RollNo.Focus();
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            FCon_Start();

            if(tb_RollNo.Text !="")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Select * From Student_Details Where Roll_No=@RNo";
                cmd.Connection = FCon;

                cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_RollNo.Text;

                SqlDataReader Dr = cmd.ExecuteReader();

                if(Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    dtp_DOB.Text = (Dr["DOB"].ToString());
                    tb_Mobile_No.Text = (Dr["Mobile_No"].ToString());
                    cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));
                }
                else
                {
                    MessageBox.Show("No Record Found", "Invalid Roll No", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_RollNo.Clear();
                    tb_RollNo.Focus();
                }
            }

            FCon_Stop();
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }
        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student_Details obj = new frm_Add_New_Student_Details();
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
