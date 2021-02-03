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
    public partial class frmYearOfStudy : Form
    {
        public frmYearOfStudy()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSemester.Text = "";
            txtStatus.Text = "";
            txtYearCode.Text = "";
            txtYos.Text = "";
            txtYearCode.Focus();
        }
    }
}
