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
    public partial class frmCenter : Form
    {
        public frmCenter()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCenterCode.Text = "";
            txtCenterName.Text = "";
            txtLocation.Text = "";
            txtUniversityName.Text = "";
            txtCenterCode.Focus();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCenterCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCenterCode.Focus();

            }
            else if (txtCenterName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCenterName.Focus();

            }
            else if (txtLocation.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLocation.Focus();

            }
            else if (txtUniversityName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUniversityName.Focus();

            }
            else if (txtCenterName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCenterName.Focus();

            }
            else
            {
            }
        }
    }
}
