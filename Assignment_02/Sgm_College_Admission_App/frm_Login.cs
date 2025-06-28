using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sgm_College_Admission_App
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            tb_UserName.Focus();

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
           if((tb_UserName.Text == "a" && tb_Password.Text == "a") || (tb_UserName.Text == "Admin" && tb_Password.Text == "a123"))
            {
                MessageBox.Show("Login Successful", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Add_New_Student_Details obj = new frm_Add_New_Student_Details();
                obj.Show();
                this.Hide();

                Shared_Content.Uname = tb_UserName.Text;
            }
            else
            {
                MessageBox.Show("Enter Correct Username and Password", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            tb_UserName.Clear();
            tb_Password.Clear();

            tb_Password.Enabled = false;
            tb_UserName.Visible = true;
            
        }

        private void tb_UserName_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
            lbl_Error.Visible = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;

        }
    }
}
