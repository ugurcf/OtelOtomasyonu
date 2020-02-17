using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelProjev1
{
    public partial class FrmPersonelBilgi : Form
    {
        public FrmPersonelBilgi()
        {
            InitializeComponent();
        }
        SQL sql = new SQL();
        private void btnPersonelKaydet_Click(object sender, EventArgs e)
        {
            sql.PersonelEkle(txtPerTc.Text, textPerad.Text, textPersoyad.Text, textPertelefon.Text, textPeradres.Text, textPerdepartman.Text, textPerpozisyon.Text, txtPerPuan.Text, txtPerCalistigiOtel.Text);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaForm frm = new FrmAnaForm();
            frm.Show();
            this.Hide();
        }
    }
}
