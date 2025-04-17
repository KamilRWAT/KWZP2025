using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormMainPanel : Form
    {
        public KWZPEntities db = new KWZPEntities();

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(childForm);
            panel_Main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public FormMainPanel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = db.V_PozostalyUrlop.ToList(); 
        }

        private void btn_Form1_Click(object sender, EventArgs e)
        {
            //Form frm = new Form1();
            //frm.TopLevel = false;
            //frm.Dock = DockStyle.Fill;
            //frm.FormBorderStyle = FormBorderStyle.None;
            //panel_Main.Controls.Add(frm);
            //frm.BringToFront();
            //frm.Show();
            OpenChildForm(new Form1());
        }

        private void btn_PozostalyUrlop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPozostalyUrlop(db));
        }
    }
}
