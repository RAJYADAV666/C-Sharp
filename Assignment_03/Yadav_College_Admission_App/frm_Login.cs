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
    public partial class frm_Login : Form
    {
        public frm_Login()
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

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            FCon_Start();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = FCon;
            Cmd.CommandText = "Select Count(*) From Login_Details Where UserName = @UNm And Password = @Pw";

            Cmd.Parameters.Add("UNm", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pw", SqlDbType.NVarChar).Value = tb_Password.Text;

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if(Cnt > 0)
            {
                MessageBox.Show("Welcome To Yadav College App", "Login Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Shared_Content.UserName = tb_Username.Text;

                frm_Add_New_Student obj = new frm_Add_New_Student();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect UserName && Password ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tb_Username.Clear();
            tb_Password.Clear();

            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;

            tb_Username.Focus();

            FCon_Stop();

        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
            lbl_Error.Visible = true;

        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            tb_Username.Focus();
        }
    }
}
