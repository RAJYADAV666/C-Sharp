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
    public partial class frm_Student_Details : Form
    {
        public frm_Student_Details()
        {
            InitializeComponent();
        }
        private void frm_Student_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sgm_Admission_Systeam_DBDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.sgm_Admission_Systeam_DBDataSet.Student_Details);
            lbl_UserName.Text = "Welcome " + Shared_Content.Uname;
        }
        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student_Details obj = new frm_Add_New_Student_Details();
            obj.Show();
            this.Hide();
        }
        private void btn_Search_Student_Click(object sender, EventArgs e)
        {
            frm_Search obj = new frm_Search();
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
