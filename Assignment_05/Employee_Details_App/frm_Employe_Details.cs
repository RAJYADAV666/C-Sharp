using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Details_App
{
    public partial class frm_Employe_Details : Form
    {
        public frm_Employe_Details()
        {
            InitializeComponent();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;

            }
        }

        private void frm_Employe_Details_Load(object sender, EventArgs e)
        {
            tb_Name.Focus();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Output = "";
            bool Flag = true;

            if(tb_Name.Text !="")
            {
                Output = tb_Name.Text + " From department ";

                if(Cmb_Details.Text !="")
                {
                    Output += Cmb_Details.Text + " is ";

                    if(rdb_Male.Checked == true)
                    {
                        Output += rdb_Male.Text + " Candidate , Prefers Shift timing";
                    }
                    else if(rdb_Female.Checked == true)
                    {
                        Output += rdb_Female.Text + " Candidate , Prefer shift timing";
                    }
                    else
                    {
                        MessageBox.Show("Select Gender  of Employee ", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Flag = false;
                    }

                    if(rdb_Morning.Checked == true)
                    {
                        Output += rdb_Morning.Text + " . ";
                    }
                    else if(rdb_Evening.Checked == true)
                    {
                        Output += rdb_Evening.Text + " . ";
                    }
                    else if(rdb_Night.Checked == true)
                    {
                        Output += rdb_Night.Text + " . ";
                    }
                    else
                    {
                        MessageBox.Show("Select Shift Time", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Flag = false;
                    }
                }
                else
                {
                    MessageBox.Show("Select Employee Department ", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Flag = false;
                }

            }
            else
            {
                MessageBox.Show("Enter the Name of Employee", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Flag = false;
            }

            if(Flag == true)
            {
                tb_Output.Text = Output;
            }
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Name.Clear();
            tb_Output.Clear();
            Cmb_Details.SelectedIndex = -1;

            rdb_Male.Checked = false;
            rdb_Female.Checked = false;

            rdb_Morning.Checked = false;
            rdb_Evening.Checked = false;
            rdb_Night.Checked = false;

        }

      
    }
}
