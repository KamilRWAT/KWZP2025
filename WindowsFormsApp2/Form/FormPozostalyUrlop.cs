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
            dgv_PozostalyUrlop.Columns["Produkcja_produktu"].Visible = false;
        }

        private void FormPozostalyUrlop_Load(object sender, EventArgs e)
        {

        }

        private void btn_DodajProdukt_Click(object sender, EventArgs e)
        {
            try
            {
                Produkt produkt = new Produkt();
                produkt.nazwa = "Emilia4";
                List<Produkt> ostatniProdukt = _db.Produkt.ToList();
                int index = ostatniProdukt.Last().id_produktu;
                produkt.id_produktu = index+1;
                _db.Produkt.Add(produkt);
                _db.SaveChanges();
                dgv_PozostalyUrlop.DataSource = null;
                dgv_PozostalyUrlop.DataSource = _db.Produkt.ToList();
                dgv_PozostalyUrlop.Update();
                dgv_PozostalyUrlop.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
