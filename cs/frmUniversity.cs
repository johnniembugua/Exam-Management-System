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
    public partial class frmUniversity : Form
    {
        public frmUniversity()
        {
            InitializeComponent();
        }

        private void frmUniversity_Load(object sender, EventArgs e)
        {
            this.Width = this.MdiParent.Width;
            this.Height = this.MdiParent.Height;

            gboUniversity.Left = (this.Width - gboUniversity.Width) / 2;
            gboUniversity.Top = (this.Height - gboUniversity.Height) / 2;
            
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUniversityCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUniversityCode.Focus();
                
            }
            else if (txtUniversityName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUniversityName.Focus();

            }
            else if (txtLocation.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLocation.Focus();

            }
            else if (txtPostalAddress.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPostalAddress.Focus();

            }
            else if (txtTown.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown.Focus();

            }
            else if (txtZipCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtZipCode.Focus();

            }
            else
            {

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLocation.Text = "";
            txtPostalAddress.Text="";
            txtTown.Text="";
            txtUniversityCode.Text="";
            txtUniversityName.Text="";
            txtZipCode.Text="";
            txtUniversityCode.Focus();
        }
    }
}
