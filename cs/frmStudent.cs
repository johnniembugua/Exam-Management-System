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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAcadCode.Text = "";
            txtEmailAddress.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtMName.Text = "";
            txtPhoneNo.Text = "";
            txtPostalAddress.Text = "";
            txtProgCode.Text = "";
            txtRegNo.Text = "";
            txtStatus.Text = "";
            txtYearCode.Text = "";
            txtAcadCode.Focus();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAcadCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAcadCode.Focus();

            }
            else if (txtEmailAddress.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();

            }
            else if (txtFName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFName.Focus();

            }
            else if (txtLName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLName.Focus();

            }
            else if (txtMName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMName.Focus();

            }
            else if (txtPhoneNo.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNo.Focus();

            }
            else if (txtPostalAddress.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPostalAddress.Focus();

            }
            else if (txtRegNo.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegNo.Focus();

            }
            else if (txtStatus.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStatus.Focus();

            }
            else if (txtYearCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYearCode.Focus();

            }
            else
            { 
            }
        }

        private void gboUniversity_Enter(object sender, EventArgs e)
        {

        }
    }
}
