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
    public partial class frmFaculty : Form
    {
        public frmFaculty()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDescription.Text = "";
            txtFacultyCode.Text = "";
            txtFacultyName.Text = "";
            txtFacultyCode.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
