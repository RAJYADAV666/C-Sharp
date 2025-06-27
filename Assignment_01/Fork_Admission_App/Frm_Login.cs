using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fork_Admission_App
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void tb_UserName_TextChanged(object sender, EventArgs e)
        {
            tb_UserName.Focus();
            tb_Password.Enabled = true;
            lbl_Error.Visible = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
           if((tb_UserName.Text == "Admin" && tb_Password.Text == "a123")|| (tb_UserName.Text == "a" && tb_Password.Text == "a"))
            {
                MessageBox.Show("Login Successful ", "WELCOME");
                Frm_Add_New_Student_Details obj = new Frm_Add_New_Student_Details();
                obj.Show();
                this.Hide();
            }
           else
            {
                MessageBox.Show("Login Failed", "Failure");
                lbl_Error.Text = "Login Failed , Enter Correct UserName/Password.";
                lbl_Error.ForeColor = Color.OrangeRed;
            }

            tb_UserName.Clear();
            tb_Password.Clear();

            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;

            tb_UserName.Focus();
        }
    }
}
