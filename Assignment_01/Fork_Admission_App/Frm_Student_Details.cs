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
    public partial class Frm_Student_Details : Form
    {
        public Frm_Student_Details()
        {
            InitializeComponent();
        }

        private void Frm_Student_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fork_Admission_Systeam_DBDataSet1.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.fork_Admission_Systeam_DBDataSet1.Student_Details);

        }

        private void lbl_Add_New_Student_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Student_Details obj = new Frm_Add_New_Student_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Frm_Login obj = new Frm_Login();
            obj.Show();
            this.Hide();

        }
    }
}
