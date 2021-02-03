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
    public partial class frmAcademicYear : Form
    {
        public frmAcademicYear()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAcadCode.Text = "";
            txtAcadYear.Text = "";
            txtStatus.Text = "";
            txtAcadCode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAcadCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAcadCode.Focus();

            }
            else if (txtAcadYear.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAcadYear.Focus();

            }
            else if (txtStatus.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStatus.Focus();

            }
            else
            { 
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
