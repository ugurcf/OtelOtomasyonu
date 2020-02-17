using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtelProjev1
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-ONB0MHF9;Initial Catalog=OtelVeriTabanı;Integrated Security=True");
        private void FrmGiris_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Tbl_Musteri where KullaniciAd=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if(txtKullaniciAd.Text.ToLower()=="a" && txtSifre.Text=="0")
                {
                    //MessageBox.Show("Admin girişi başarılı!");
                    FrmAnaForm frm = new FrmAnaForm();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MusteriForm frm = new MusteriForm();
                    frm.musteriİD = txtKullaniciAd.Text;

                    
                    frm.Show();
                    this.Hide();
                }
               
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
            baglanti.Close();

        }
        
        
    }
}
