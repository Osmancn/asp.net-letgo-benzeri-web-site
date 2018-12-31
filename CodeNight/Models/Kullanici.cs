using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeNight
{
    public class Kullanici
    {
        public int kullaniciID { get;  set; }
        public string ad { get;  set; }
        public string soyad { get;  set; }
        public string eposta { get;  set; }
        public string sifre { get;  set; }
        public string fotoLink { get; set; }

        public List<int> favoriUrunID;
        public List<Sohbet> sohbetler;

        public Kullanici()
        {

        }
        public Kullanici(string ad,string soyad,string sifre,string eposta)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.sifre = sifre;
            this.eposta = eposta;
        }
        public Kullanici(int id, string ad, string soyad, string sifre, string eposta)
        {
            this.kullaniciID = id;
            this.ad = ad;
            this.soyad = soyad;
            this.sifre = sifre;
            this.eposta = eposta;
        }

        public void FavoriEkle(int id)
        {
            if (favoriUrunID == null)
                favoriUrunID = new List<int>();
            favoriUrunID.Add(id);
        }

        public void SohbetEkle(List<Mesaj> mesajlaşmalar)
        {
            int id;

            if (sohbetler == null)
                sohbetler = new List<Sohbet>();

            if (mesajlaşmalar[0].aliciID != kullaniciID)
                id = mesajlaşmalar[0].aliciID;
            else
                id = mesajlaşmalar[0].gondericiID;

            Sohbet s = new Sohbet(id);
            s.MesajEkle(mesajlaşmalar);

            sohbetler.Add(s);
        }
    }
}