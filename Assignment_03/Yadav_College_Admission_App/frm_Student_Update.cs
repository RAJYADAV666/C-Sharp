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
    public partial class frm_Student_Update : Form
    {
        public frm_Student_Update()
        {
            InitializeComponent();
        }

        SqlConnection FCon = new SqlConnection(@"Data Source=DESKTOP-D15T778;Initial Catalog=Yadav_Admission_Systeam_DB;Integrated Security=True");

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
            tb_MobileNo.Clear();
            cmb_Course.SelectedIndex = -1;

            dtp_DOB.Text = "01-01-2000";
        }

        void Enable_Control()
        {
            tb_Name.Enabled = true;
            tb_MobileNo.Enabled = true;
            cmb_Course.Enabled = true;
            dtp_DOB.Enabled = true;

            tb_RollNo.Enabled = false;
        }

        void Disable_Control()
        {
            tb_Name.Enabled = false;
            tb_MobileNo.Enabled = false;
            cmb_Course.Enabled = false;
            dtp_DOB.Enabled = false;

            tb_RollNo.Enabled = true;
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            FCon_Start();

            if (tb_RollNo.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Select * From Student_Details Where Roll_No=@RNo";
                cmd.Connection = FCon;

                cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_RollNo.Text;

                SqlDataReader Dr = cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    dtp_DOB.Text = (Dr["DOB"].ToString());
                    tb_MobileNo.Text = (Dr["Mobile_No"].ToString());
                    cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));
                }
                else
                {
                    MessageBox.Show("No Record Found", "Invalid Roll No", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    tb_RollNo.Clear();
                    tb_RollNo.Focus();
                }

                FCon_Stop();
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            FCon_Start();

            if(tb_RollNo.Text !="" && tb_Name.Text !="" && tb_MobileNo.Text !="" && cmb_Course.SelectedIndex >= 0)
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = FCon;

                Cmd.CommandText = "Update Student_Details Set Name = @Nm , DOB = @Db, Mobile_No = @MNo , Course = @Course Where Roll_No = @RNo";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_RollNo.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_MobileNo.Text;
                Cmd.Parameters.Add("Db", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Student Details Updated Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Control();
                Disable_Control();
                
            }
            else
            {
                MessageBox.Show(" Fill all Fields");
            }

            FCon_Stop();

        }

        private void frm_Student_Update_Load(object sender, EventArgs e)
        {
            lbl_UserName.Text = Shared_Content.UserName;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }
        private void btn_Student_Search_Click(object sender, EventArgs e)
        {
            frm_Student_Search obj = new frm_Student_Search();
            obj.Show();
            this.Hide();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.Show();
            this.Hide();
        }

        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_List obj = new frm_Student_List();
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
