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
    public partial class frmProgramme : Form
    {
        public frmProgramme()
        {
            InitializeComponent();
        }

        private void frmProgramme_Load(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDepCode.Text = "";
            txtDescription.Text = "";
            txtDuration.Text = "";
            txtProCode.Text = "";
            txtProgName.Text = "";
            txtZipCode.Text = "";
            txtDepCode.Focus();
        }
    }
}
