using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProjev1
{//Hata Veriyor diye kapadık!
    public class İkiliAramaAgaci
    {
        private İkiliAramaAgacDugumu kok;
        private string dugumler;
        public İkiliAramaAgaci()
        {
        }
        public İkiliAramaAgaci(İkiliAramaAgacDugumu kok)
        {
            this.kok = kok;
        }
        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }

        public string IlIlceDugumSayisi(string il, string ilce)
        {
            return IlIlceDugumSayisi(kok,il,ilce);
        }

        public string IlIlceYildizDugumSayisi(string il, string ilce)
        {
            return IlIlceYildizDugumSayisi(kok, il, ilce);
        }

        public string IlIlcePuanDugumSayisi(string il, string ilce)
        {
            return IlIlcePuanDugumSayisi(kok, il, ilce);
        }

        public int DugumSayisi(İkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;
        }
        string oa = "";
        public string IlIlceDugumSayisi(İkiliAramaAgacDugumu dugum,string il, string ilce)
        {
            
            if (dugum != null)
            {
                if ((dugum.veri as Otel).Il == il && (dugum.veri as Otel).Ilce == ilce)
                {
                    oa +=  (dugum.veri as Otel).Ad + " " +(dugum.veri as Otel).Il + " " + (dugum.veri as Otel).Ilce + " " + Environment.NewLine;
                }
                IlIlceDugumSayisi(dugum.sol, il,ilce);
                IlIlceDugumSayisi(dugum.sag, il,ilce);
            }
            return oa;
        }

        string yildiz5 = "";
        string yildiz4 = "";
        string yildiz3 = "";
        string yildiz2 = "";
        string yildiz1 = "";
        string qa = "";
        public string IlIlceYildizDugumSayisi(İkiliAramaAgacDugumu dugum, string il, string ilce)
        {
            
                if (dugum != null)
                {
                    if ((dugum.veri as Otel).Il == il && (dugum.veri as Otel).Ilce == ilce && Convert.ToInt32((dugum.veri as Otel).Yildiz) == 5)
                    {
                        yildiz5 += (dugum.veri as Otel).Ad + " " + (dugum.veri as Otel).Il + " " + (dugum.veri as Otel).Ilce + " " + (dugum.veri as Otel).Yildiz + " " + Environment.NewLine;
                    }
                    if ((dugum.veri as Otel).Il == il && (dugum.veri as Otel).Ilce == ilce && Convert.ToInt32((dugum.veri as Otel).Yildiz) == 4)
                    {
                        yildiz4 += (dugum.veri as Otel).Ad + " " + (dugum.veri as Otel).Il + " " + (dugum.veri as Otel).Ilce + " " + (dugum.veri as Otel).Yildiz + " " + Environment.NewLine;
                    }
                    if((dugum.veri as Otel).Il == il && (dugum.veri as Otel).Ilce == ilce && Convert.ToInt32((dugum.veri as Otel).Yildiz) == 3)
                    {
                        yildiz3 += (dugum.veri as Otel).Ad + " " + (dugum.veri as Otel).Il + " " + (dugum.veri as Otel).Ilce + " " + (dugum.veri as Otel).Yildiz + " " + Environment.NewLine;
                    }
                    if((dugum.veri as Otel).Il == il && (dugum.veri as Otel).Ilce == ilce && Convert.ToInt32((dugum.veri as Otel).Yildiz) == 2)
                    {
                        yildiz2 += (dugum.veri as Otel).Ad + " " + (dugum.veri as Otel).Il + " " + (dugum.veri as Otel).Ilce + " " + (dugum.veri as Otel).Yildiz + " " + Environment.NewLine;
                    }
                    if((dugum.veri as Otel).Il == il && (dugum.veri as Otel).Ilce == ilce && Convert.ToInt32((dugum.veri as Otel).Yildiz) == 1)
                    {
                        yildiz1 += (dugum.veri as Otel).Ad + " " + (dugum.veri as Otel).Il + " " + (dugum.veri as Otel).Ilce + " " + (dugum.veri as Otel).Yildiz + " " + Environment.NewLine;
                    }


                }

            if (dugum != null)
            {
                IlIlceYildizDugumSayisi(dugum.sol, il, ilce);
                IlIlceYildizDugumSayisi(dugum.sag, il, ilce);
            }
            qa = yildiz5 + yildiz4 + yildiz3 + yildiz2 + yildiz1;
            return qa;
        }

        string puan10 = "";
        string puan9 = "";
        string puan8 = "";
        string puan7 = "";
        string puan6 = "";
        string puan5 = "";
        string puan4 = "";
        string puan3 = "";
        string puan2 = "";
        string puan1 = "";
        string puana = "";
        public string IlIlcePuanDugumSayisi(İkiliAramaAgacDugumu dugum, string il, string ilce)
        {

            if (dugum != null)
            {
                if ((dugum.veri as Otel).Il == il && (dugum.veri as Otel).Ilce == ilce && Convert.ToInt32((dugum.veri as Otel).Puan) == 10)
                {
                    puan10 += (dugum.veri as Otel).Ad + " " + (dugum.veri as Otel).Il + " " + (dugum.veri as Otel).Ilce + " " + (dugum.veri as Otel).Puan + " " + Environment.NewLine;
                }
                if ((dugum.veri as Otel).Il == il && (dugum.veri as Otel).Ilce == ilce && Convert.ToInt32((dugum.veri as Otel).Puan) == 9)
                {
                    puan9 += (dugum.veri as Otel).Ad + " " + (dugum.veri as Otel).Il + " " + (dugum.veri as Otel).Ilce + " " + (dugum.veri as Otel).Puan + " " + Environment.NewLine;
                }
                if ((dugum.veri as Otel).Il == il && (dugum.veri as Otel).Ilce == ilce && Convert.ToInt32((dugum.veri as Otel).Puan) == 8)
                {
                    puan8 += (dugum.veri as Otel).Ad + " " + (dugum.veri as Otel).Il + " " + (dugum.veri as Otel).Ilce + " " + (dugum.veri as Otel).Puan + " " + Environment.NewLine;
                }
                if ((dugum.veri as Otel).Il == il && (dugum.veri as Otel).Ilce == ilce && Convert.ToInt32((dugum.veri as Otel).Puan) == 7)
                {
                    puan7 += (dugum.veri as Otel).Ad + " " + (dugum.veri as Otel).Il + " " + (dugum.veri as Otel).Ilce + " " + (dugum.veri as Otel).Puan + " " + Environment.NewLine;
                }
                if ((dugum.veri as Otel).Il == il && (dugum.veri as Otel).Ilce == ilce && Convert.ToInt32((dugum.veri as Otel).Puan) == 6)
                {
                    puan6 += (dugum.veri as Otel).Ad + " " + (dugum.veri as Otel).Il + " " + (dugum.veri as Otel).Ilce + " " + (dugum.veri as Otel).Puan + " " + Environment.NewLine;
                }
                if ((dugum.veri as Otel).Il == il && (dugum.veri as Otel).Ilce == ilce && Convert.ToInt32((dugum.veri as Otel).Puan) == 5)
                {
                    puan5 += (dugum.veri as Otel).Ad + " " + (dugum.veri as Otel).Il + " " + (dugum.veri as Otel).Ilce + " " + (dugum.veri as Otel).Puan + " " + Environment.NewLine;
                }
                if ((dugum.veri as Otel).Il == il && (dugum.veri as Otel).Ilce == ilce && Convert.ToInt32((dugum.veri as Otel).Puan) == 4)
                {
                    puan4 += (dugum.veri as Otel).Ad + " " + (dugum.veri as Otel).Il + " " + (dugum.veri as Otel).Ilce + " " + (dugum.veri as Otel).Puan + " " + Environment.NewLine;
                }
                if ((dugum.veri as Otel).Il == il && (dugum.veri as Otel).Ilce == ilce && Convert.ToInt32((dugum.veri as Otel).Puan) == 3)
                {
                    puan3 += (dugum.veri as Otel).Ad + " " + (dugum.veri as Otel).Il + " " + (dugum.veri as Otel).Ilce + " " + (dugum.veri as Otel).Puan + " " + Environment.NewLine;
                }
                if ((dugum.veri as Otel).Il == il && (dugum.veri as Otel).Ilce == ilce && Convert.ToInt32((dugum.veri as Otel).Puan) == 2)
                {
                    puan2 += (dugum.veri as Otel).Ad + " " + (dugum.veri as Otel).Il + " " + (dugum.veri as Otel).Ilce + " " + (dugum.veri as Otel).Puan + " " + Environment.NewLine;
                }
                if ((dugum.veri as Otel).Il == il && (dugum.veri as Otel).Ilce == ilce && Convert.ToInt32((dugum.veri as Otel).Puan) == 1)
                {
                    puan1 += (dugum.veri as Otel).Ad + " " + (dugum.veri as Otel).Il + " " + (dugum.veri as Otel).Ilce + " " + (dugum.veri as Otel).Puan + " " + Environment.NewLine;
                }


            }

            if (dugum != null)
            {
                IlIlcePuanDugumSayisi(dugum.sol, il, ilce);
                IlIlcePuanDugumSayisi(dugum.sag, il, ilce);
            }
            puana = puan10 + puan9 + puan8 + puan7 + puan6+ puan5+ puan4+ puan3 + puan2+puan1;
            return puana;
        }

        public void Temizle()
        {
            qa = "";
            oa = "";
            puana = "";
            puan10 = "";
            puan9 = "";
            puan8 = "";
            puan7 = "";
            puan6 = "";
            puan5 = "";
            puan4 = "";
            puan3 = "";
            puan2 = "";
            puan1 = "";
            yildiz5 = "";
            yildiz4 = "";
            yildiz3 = "";
            yildiz2 = "";
            yildiz1 = "";
        }

        public int YaprakSayisi()
        {
            return YaprakSayisi(kok);
        }

        public int YaprakSayisi(İkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                if ((dugum.sol == null) && (dugum.sag == null))
                    count = 1;
                else
                    count = count + YaprakSayisi(dugum.sol) + YaprakSayisi(dugum.sag);
            }
            return count;
        }
        public string DugumleriYazdir()
        {
            return dugumler;
        }
        public void PreOrder()
        {
            dugumler = "";
            PreOrderInt(kok);
        }
        private void PreOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }
        public void InOrder()
        {
            dugumler = "";
            InOrderInt(kok);
        }
        private void InOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
        private void Ziyaret(İkiliAramaAgacDugumu dugum)
        {
            // dugumler += dugum.veri + " ";
            dugumler += "ad " + (dugum.veri as Otel).Ad + "  " +
             "il  " + (dugum.veri as Otel).Il + Environment.NewLine;
        }
        public void PostOrder()
        {
            dugumler = "";
            PostOrderInt(kok);
        }
        private void PostOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }
        public void Ekle(Otel o)
        {
            //Yeni eklenecek düğümün parent'ı
            İkiliAramaAgacDugumu tempParent = new İkiliAramaAgacDugumu();
            //Kökten başla ve ilerle
            İkiliAramaAgacDugumu tempSearch = kok;


            char[] adDizisi = new char[100];
            byte[] asci = new byte[100];
            byte[] _asci = new byte[100];
            char[] _adDizisi = new char[100];
            string ad = o.Ad.ToLower();
            adDizisi = ad.ToCharArray();
            asci = System.Text.Encoding.UTF8.GetBytes(adDizisi);

            while (tempSearch != null)
            {
                tempParent = tempSearch;

                _adDizisi = (tempSearch.veri as Otel).Ad.ToLower().ToCharArray();
                _asci = System.Text.Encoding.UTF8.GetBytes(_adDizisi);
                //Deger zaten var, çık.

                if (o.Ad == (tempSearch.veri as Otel).Ad)
                {
                    return;
                }

                else if (asci[0] < _asci[0])
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sag;
            }

            İkiliAramaAgacDugumu eklenecek = new İkiliAramaAgacDugumu(o);
            //Ağaç boş, köke ekle
            if (kok == null)
                kok = eklenecek;
            if (asci[0] == _asci[0])
            {
                if (asci[1] < _asci[1])
                    tempParent.sol = eklenecek;
                else
                    tempParent.sag = eklenecek;
            }
            else if (asci[0] < _asci[0])
                tempParent.sol = eklenecek;
            else
                tempParent.sag = eklenecek;
        
        }
        
        public İkiliAramaAgacDugumu Ara(int anahtar)
        {
            return AraInt(kok, anahtar);
        }

        private İkiliAramaAgacDugumu AraInt(İkiliAramaAgacDugumu dugum,
                                            int anahtar)
        {
            if (dugum == null)
                return null;
            else if ((int)dugum.veri == anahtar)
                return dugum;
            else if ((int)dugum.veri > anahtar)
                return (AraInt(dugum.sol, anahtar));
            else
                return (AraInt(dugum.sag, anahtar));
        }
        
        public İkiliAramaAgacDugumu MinDeger()
        {
            İkiliAramaAgacDugumu tempSol = kok;
            while (tempSol.sol != null)
                tempSol = tempSol.sol;
            return tempSol;
        }
     
    }

}
