using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace OtelProjev1
{
    public class SQL
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-ONB0MHF9;Initial Catalog=OtelVeriTabanı;Integrated Security=True");

        public void OtelEkle(string OtelAd,string Bulil,string Bulilce,string Adres,string Telefon,string Eposta,string Yıldızsayisi,string Odasayisi,string Odatipi,string Otelpuani)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_OtelBilgi (Ad,Bulunduguil,Bulunduguilce,Adres,Telefon,Eposta,Yıldızsayisi,Odasayisi,Odatipi,OtelPuani) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglanti);
            komut.Parameters.AddWithValue("@p1", OtelAd);
            komut.Parameters.AddWithValue("@p2", Bulil);
            komut.Parameters.AddWithValue("@p3", Bulilce);
            komut.Parameters.AddWithValue("@p4", Adres);
            komut.Parameters.AddWithValue("@p5", Telefon);
            komut.Parameters.AddWithValue("@p6", Eposta);
            komut.Parameters.AddWithValue("@p7", Yıldızsayisi);
            komut.Parameters.AddWithValue("@p8", Odasayisi);
            komut.Parameters.AddWithValue("@p9", Odatipi);
            komut.Parameters.AddWithValue("@p10",Otelpuani);

            komut.ExecuteNonQuery(); // sorguyu çalıştırır insert/update/delete işlemlerinde kullanılır.
            baglanti.Close();
        }
        public void OtelBilgisiGuncelle(string OtelAd, string Bulil, string Bulilce, string Adres, string Telefon, string Eposta, string Yıldızsayisi, string Odasayisi, string Odatipi, string Otelpuani,string Otelid)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Tbl_OtelBilgi Set Ad=@p1,Bulunduguil=@p2,Bulunduguilce=@p3,Adres=@p4,Telefon=@p5,Eposta=@p6,Yıldızsayisi=@p7,Odasayisi=@p8,Odatipi=@p9,OtelPuani=@p10 where Otelid=@p11", baglanti);
            komut.Parameters.AddWithValue("@p1", OtelAd);
            komut.Parameters.AddWithValue("@p2", Bulil);
            komut.Parameters.AddWithValue("@p3", Bulilce);
            komut.Parameters.AddWithValue("@p4", Adres);
            komut.Parameters.AddWithValue("@p5", Telefon);
            komut.Parameters.AddWithValue("@p6", Eposta);
            komut.Parameters.AddWithValue("@p7", Yıldızsayisi);
            komut.Parameters.AddWithValue("@p8", Odasayisi);
            komut.Parameters.AddWithValue("@p9", Odatipi);
            komut.Parameters.AddWithValue("@p10", Otelpuani);
            komut.Parameters.AddWithValue("@p11",Otelid);
            komut.ExecuteNonQuery();
            baglanti.Close();
            //listelemeyeli hemen görmemiz lazım
        }
        public void OtelSil(string Otelid)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_OtelBilgi Where Otelid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", Otelid);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
        }
        public void PersonelEkle(string Pertc,string PerAd,string PerSoyad,string PerTel,string PerAdres,string PerDepartman,string PerPozisyon,string PerPuan,string PerCalistigiOtel)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (Pertc,PerAd,PerSoyad,PerTel,PerAdres,PerDepartman,PerPozisyon,PerPuan,CalistigiOtel) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);
            komut.Parameters.AddWithValue("@p1", Pertc);
            komut.Parameters.AddWithValue("@p2", PerAd);
            komut.Parameters.AddWithValue("@p3", PerSoyad);
            komut.Parameters.AddWithValue("@p4", PerTel);
            komut.Parameters.AddWithValue("@p5", PerAdres);
            komut.Parameters.AddWithValue("@p6", PerDepartman);
            komut.Parameters.AddWithValue("@p7", PerPozisyon);
            komut.Parameters.AddWithValue("@p8", PerPuan);
            komut.Parameters.AddWithValue("@p9", PerCalistigiOtel);
            komut.ExecuteNonQuery(); // sorguyu çalıştırır insert/update/delete işlemlerinde kullanılır.
            baglanti.Close();
        }
        public void PersonelBilgisiGuncelle(string Perid,string Pertc,string PerAd,string PerSoyad,string PerTel,string PerAdres,string PerDepartman,string PerPozisyon,string PerPuan,string CalistigiOtel)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Tbl_Personel Set Pertc=@p1,PerAd=@p2,PerSoyad=@p3,PerTel=@p4,PerAdres=@p5,PerDepartman=@p6,PerPozisyon=@p7,PerPuan=@p8,CalistigiOtel=@p9 where Perid=@p10", baglanti);
            komut.Parameters.AddWithValue("@p1", Pertc);
            komut.Parameters.AddWithValue("@p2", PerAd);
            komut.Parameters.AddWithValue("@p3", PerSoyad);
            komut.Parameters.AddWithValue("@p4", PerTel);
            komut.Parameters.AddWithValue("@p5", PerAdres);
            komut.Parameters.AddWithValue("@p6", PerDepartman);
            komut.Parameters.AddWithValue("@p7", PerPozisyon);
            komut.Parameters.AddWithValue("@p8", PerPuan);
            komut.Parameters.AddWithValue("@p9", CalistigiOtel);
            komut.Parameters.AddWithValue("@p10", Perid);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public DataTable DepartmanaGoreListele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Personel ORDER BY PerDepartman desc", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            baglanti.Close();
            return ds.Tables[0];
        }
        public DataTable verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public DataTable PuanaGoreListele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Personel ORDER BY PerPuan desc", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            baglanti.Close();
            return ds.Tables[0];
        }
        public void PersonelSil(string Perid)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel Where Perid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", Perid);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
        }
        public void PersonelePuanVer(string Perid,string PerPuan)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Tbl_Personel Set PerPuan=@p1 where Perid=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", PerPuan);
            komut.Parameters.AddWithValue("@p2", Perid);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
     
        public void BaglantiKapat()
        {
            baglanti.Close();
        }
        public void OtelePuanVer(string Otelid,string OtelPuani)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Tbl_OtelBilgi Set OtelPuani=@p1 where Otelid=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", OtelPuani);
            komut.Parameters.AddWithValue("@p2", Otelid);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void YorumYap(string Otelid,string Musteriid,string MusteriAd,string MusteriSoyad,string MusteriEposta,string MusteriYorum)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Yorum (Müsteriid,MusteriAd,MusteriSoyad,Eposta,MusteriYorum,Otelid) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", Musteriid);
            komut.Parameters.AddWithValue("@p2", MusteriAd);
            komut.Parameters.AddWithValue("@p3", MusteriSoyad);
            komut.Parameters.AddWithValue("@p4", MusteriEposta);
            komut.Parameters.AddWithValue("@p5", MusteriYorum);
            komut.Parameters.AddWithValue("@p6", Otelid);
            komut.ExecuteNonQuery(); // sorguyu çalıştırır insert/update/delete işlemlerinde kullanılır.
            baglanti.Close();
        }
        public İkiliAramaAgaci AgacaOtelEKle(LinkedList Calisan, LinkedList2 Yorumlar)
        {
            İkiliAramaAgaci agac = new İkiliAramaAgaci();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_OtelBilgi", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Otel o = new Otel();
                int OtelAdi = dr.GetOrdinal("Ad");
                int OtelID = dr.GetOrdinal("Otelid");
                int Bulunduguil = dr.GetOrdinal("Bulunduguil");
                int Bulunduguilce = dr.GetOrdinal("Bulunduguilce");
                int Adres= dr.GetOrdinal("Adres");
                int Telefon = dr.GetOrdinal("Telefon");
                int Eposta = dr.GetOrdinal("Eposta");
                int Yıldızsayisi = dr.GetOrdinal("Yıldızsayisi");
                int Odasayisi = dr.GetOrdinal("Odasayisi");
                int Odatipi = dr.GetOrdinal("Odatipi");
                int OtelPuani = dr.GetOrdinal("OtelPuani");
                o.Ad = dr.GetString(OtelAdi);
                o.OtelID = dr.GetInt16(OtelID);
                o.Il = dr.GetString(Bulunduguil);
                o.Ilce = dr.GetString(Bulunduguilce);
                o.Adres = dr.GetString(Adres);
                o.Telefon = dr.GetString(Telefon);
                o.Eposta = dr.GetString(Eposta);
                o.Yildiz = dr.GetString(Yıldızsayisi);
                o.OdaSayisi = dr.GetString(Odasayisi);
                o.OdaTipi = dr.GetString(Odatipi);
                o.Puan = dr.GetString(OtelPuani);

                o.OtelCalisani = Calisan.OteleGoreCalisan(o.OtelID);
                o.OtelYorumlari = Yorumlar.OteleGoreYorum(o.OtelID);
                agac.Ekle(o);
            }
            baglanti.Close();
            return agac;
        }
        public LinkedList PersonelEkle()
        {
            LinkedList list = new LinkedList();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Personel", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Calisan calisan = new Calisan();
                int Perid = dr.GetOrdinal("Perid");
                int Pertc = dr.GetOrdinal("Pertc");
                int PerAd = dr.GetOrdinal("PerAd");
                int PerSoyad = dr.GetOrdinal("PerSoyad");
                int PerTel = dr.GetOrdinal("PerTel");
                int PerAdres = dr.GetOrdinal("PerAdres");
                int PerDepartman = dr.GetOrdinal("PerDepartman");
                int PerPozisyon = dr.GetOrdinal("PerPozisyon");
                int PerPuan = dr.GetOrdinal("PerPuan");
                int CalistigiOtel = dr.GetOrdinal("CalistigiOtel");
                calisan.ID = dr.GetInt16(Perid);
                calisan.Ad = dr.GetString(Pertc);
                calisan.Soyad = dr.GetString(PerSoyad);
                calisan.Telefon = dr.GetString(PerTel);
                calisan.Adres = dr.GetString(PerAdres);
                calisan.Departman = dr.GetString(PerDepartman);
                calisan.Pozisyon = dr.GetString(PerPozisyon);
                calisan.CalistigiOtel = dr.GetInt16(CalistigiOtel);
                list.InsertFirst(calisan);
            }
            baglanti.Close();
            return list;
        }
        public LinkedList2 YorumEkle()
        {
            LinkedList2 list = new LinkedList2();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Yorum", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                OtelYorumlari yrm = new OtelYorumlari();
                int id = dr.GetOrdinal("Müsteriid");
                int Ad = dr.GetOrdinal("MusteriAd");
                int Soyad = dr.GetOrdinal("MusteriSoyad");
                int Eposta = dr.GetOrdinal("Eposta");
                int Yorum = dr.GetOrdinal("MusteriYorum");
                int Otelid = dr.GetOrdinal("Otelid");
                yrm.ID = dr.GetInt16(id);
                yrm.YorumcuAdi = dr.GetString(Ad);
                yrm.YorumcuSoyadi = dr.GetString(Soyad);
                yrm.YorumcuEposta = dr.GetString(Eposta);
                yrm.Yorum = dr.GetString(Yorum);
                yrm.Otelid = dr.GetInt16(Otelid);
                
                list.InsertFirst(yrm);
            }
            baglanti.Close();
            return list;
        }
        public string SatirSayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT Count(*) FROM Tbl_Yorum", baglanti);
            string verisayisi = komut.ExecuteScalar().ToString();
            baglanti.Close();
            return verisayisi;
        }
    }
}
