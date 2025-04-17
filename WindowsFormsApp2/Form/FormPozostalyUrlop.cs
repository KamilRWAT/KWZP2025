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
            dgv_PozostalyUrlop.DataSource = _db.V_NiedostepnoscPracownika.ToList();
            //dgv_PozostalyUrlop.Columns["Produkcja_produktu"].Visible = false;
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

            BW frm = new BW(_db);
            frm.BringToFront();
            frm.ShowDialog();
            dgv_PozostalyUrlop.DataSource = null;
            dgv_PozostalyUrlop.DataSource = _db.Produkt.ToList();
            dgv_PozostalyUrlop.Update();
            dgv_PozostalyUrlop.Refresh();
        }

        private void btn_trash_Click(object sender, EventArgs e)
        {
            Produkt ostatniProdukt = _db.Produkt.OrderByDescending(p => p.id_produktu).FirstOrDefault();
            try
            {
                Form FormAD = new FormAD(_db);
                FormAD.ShowDialog();
                Produkt produkt = new Produkt();
                produkt.nazwa = "Emilia4";
                List<Produkt> ostatniProdukta = _db.Produkt.ToList();
                int index = ostatniProdukta.Last().id_produktu;
                produkt.id_produktu = index + 1;
                _db.Produkt.Add(produkt);
                _db.SaveChanges();
                dgv_PozostalyUrlop.DataSource = null;
                dgv_PozostalyUrlop.DataSource = _db.Produkt.ToList();
                dgv_PozostalyUrlop.Update();
                dgv_PozostalyUrlop.Refresh();
            }
            catch (Exception ex)
            {

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
}
