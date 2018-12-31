using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeNight
{
    public class Urun
    {
        public int urunID { get; set; }
        public int kullaniciID { get; set; }
        public int kategoriID { get; set; }

        public string urunAd { get; set; }
        public string urunAciklama { get; set; }
        public decimal fiyat { get; set; }
        public string fotolink { get; set; }

        public DateTime satildigiTarih { get; set; }
        public float satildigiKonum { get; set; }
        
    }
}