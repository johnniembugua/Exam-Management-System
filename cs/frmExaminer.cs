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
    public partial class frmExaminer : Form
    {
        public frmExaminer()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtExaminerId.Text = "";
            txtExaminerName.Text = "";
            txtExaminerId.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtExaminerId.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExaminerId.Focus();

            }
            else if (txtExaminerName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExaminerName.Focus();

            }
            else { 
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
