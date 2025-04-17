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
            dgv_PozostalyUrlop.DataSource = _db.V_NiedostepnoscPracownika.ToList();
            //dgv_PozostalyUrlop.Columns["Produkcja_produktu"].Visible = false;
        }

        private void FormPozostalyUrlop_Load(object sender, EventArgs e)
        {

        }

        private void btn_DodajProdukt_Click(object sender, EventArgs e)
        {
            BW frm = new BW(_db); 
            frm.BringToFront(); 
            frm.ShowDialog(); 
            dgv_PozostalyUrlop.DataSource = null;
            dgv_PozostalyUrlop.DataSource=_db.Produkt.ToList();
            dgv_PozostalyUrlop.Update();
            dgv_PozostalyUrlop.Refresh();
        }

        private void btn_trash_Click(object sender, EventArgs e)
        {
            Produkt ostatniProdukt = _db.Produkt.OrderByDescending(p => p.id_produktu).FirstOrDefault();

            if (ostatniProdukt != null)
            {
                _db.Produkt.Remove(ostatniProdukt); 
                _db.SaveChanges(); 
                dgv_PozostalyUrlop.DataSource = _db.Produkt.ToList();
            }
            else
            {
                MessageBox.Show("Brak produktów do usunięcia.");
            }
            this.Update();
            this.Refresh();
        }
    }
}
