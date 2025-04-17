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
    public partial class FormPozostalyUrlop : Form
    {
        KWZPEntities _db;
        public FormPozostalyUrlop(KWZPEntities db)
        {
            InitializeComponent();
            _db = db;
            dgv_PozostalyUrlop.DataSource = _db.Produkt.ToList();
            for (int i = 0; i < dgv_PozostalyUrlop.Columns.Count; i++)
            {
                if (i == 0 || i == 1) 
                {
                    dgv_PozostalyUrlop.Columns[i].Visible = true; 
                }
                else
                {
                    dgv_PozostalyUrlop.Columns[i].Visible = false; 
                }
            }

        }

        private void FormPozostalyUrlop_Load(object sender, EventArgs e)
        {

        }

        private void btn_DodajProdukt_Click(object sender, EventArgs e)
        {

            Form mp = new MP(_db);
            mp.ShowDialog();
            dgv_PozostalyUrlop.DataSource = null;
            dgv_PozostalyUrlop.DataSource = _db.Produkt.ToList();
            dgv_PozostalyUrlop.Update();
            dgv_PozostalyUrlop.Refresh();
        }
    }
}
