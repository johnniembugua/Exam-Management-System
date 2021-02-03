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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            gboMain.Left = (this.Width - gboMain.Width) / 2;
            gboMain.Top = (this.Height - gboMain.Height) / 2;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (ProgressBar1.Value < 100)
            {

                ProgressBar1.Value = ProgressBar1.Value + 10;
                lblProgress.Text = "Loading.." + ProgressBar1.Value + "%";

                if (ProgressBar1.Value == 100)
                {

                    frmLogin login = new frmLogin();
                    login.Visible = true;
                    this.Hide();

                }
            }

        }
        
    }
}
