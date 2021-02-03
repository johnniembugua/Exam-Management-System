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
    public partial class dashboard : Form
    {
        private int childFormNumber = 0;

        public dashboard()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void universityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUniversity uni = new frmUniversity();
            uni.MdiParent = this;
            uni.Visible = true;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.Visible = true;
            this.Dispose();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void utilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void centreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCenter c = new frmCenter();
            c.MdiParent = this;
            c.Visible = true;
        }

        private void academicYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcademicYear fa = new frmAcademicYear();
            fa.MdiParent = this;
            fa.Visible = true;
        }

        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFaculty f = new frmFaculty();
            f.MdiParent = this;
            f.Visible = true;
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartment d = new frmDepartment();
            d.MdiParent = this;
            d.Visible=true;
        }

        private void programmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProgramme p = new frmProgramme();
            p.MdiParent = this;
            p.Visible = true;
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourse cs = new frmCourse();
            cs.MdiParent = this;
            cs.Visible = true;
        }

        private void examinerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExaminer er = new frmExaminer();
            er.MdiParent = this;
            er.Visible = true;
        }

        private void examinationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmExamination ex = new frmExamination();
            ex.MdiParent = this;
            ex.Visible = true;
        }

        private void yearOfStudyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYearOfStudy yos = new frmYearOfStudy();
            yos.MdiParent = this;
            yos.Visible = true;
        }
    }
}
