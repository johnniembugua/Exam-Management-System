using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EIMS_CS
{
    public partial class frmExamination : Form
    {
        public frmExamination()
        {
            InitializeComponent();
        }

        private void txtUniversityCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCourseCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCourseCode.Focus();

            }
            else if (txtEExaminerCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEExaminerCode.Focus();

            }
            else if (txtExamCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExamCode.Focus();

            }
            else if (txtExamDate.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExamDate.Focus();

            }
            else if (txtExaminerCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExaminerCode.Focus();

            }
            else if (txtExamType.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExamType.Focus();

            }
            else if (txtRegNo.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegNo.Focus();

            }
            else if (txtSemester.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSemester.Focus();

            }
            else if (txtCat.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCat.Focus();

            }
            else
            {

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCourseCode.Text = "";
            txtEExaminerCode.Text = "";
            txtExamCode.Text = "";
            txtExamDate.Text = "";
            txtExaminerCode.Text="";
            txtExamType.Text = "";
            txtRegNo.Text = "";
            txtSemester.Text = "";
            txtCat.Text = "";
            txtExamCode.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
