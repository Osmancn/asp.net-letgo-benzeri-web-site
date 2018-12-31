using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeNight.Models;

namespace CodeNight.Controllers
{
    public class NeLazimController : Controller
    {
        databasee database = new databasee();

        
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string eposta, string sifre)
        {
            var k = database.tblKullanici.FirstOrDefault(x => x.eposta == eposta && x.sifre == sifre);
            if (k != null)
            {
                Session["ad"] = k.ad;
                Session["soyad"] = k.soyad;
                Session["sifre"] = k.sifre;
                Session["eposta"] = k.eposta;
                Session["id"] = k.kullaniciID;
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Index()
        {
            Urun u;
            List<Urun> urunler = new List<Urun>();
            foreach (var urun in database.tblUrun)
            {
                u = new Urun()
                {
                    urunAd = urun.urunAd,
                    urunID = urun.urunID,
                    urunAciklama = urun.urunAciklama,
                    fiyat = urun.fiyat,
                    fotolink = urun.fotolink
                };

                urunler.Add(u);
            }
           
            return View(urunler);
        }

        [HttpGet]
        public ActionResult UrunDetay(int id)
        {

            tblUrun u = database.tblUrun.FirstOrDefault(x => x.urunID == id);
            Urun urun = new Urun()
            {
                urunAd = u.urunAd,
                urunAciklama = u.urunAciklama,
                urunID = u.urunID,
                fiyat = u.fiyat,
                fotolink = u.fotolink 
            };

            return View(u);
        }

        [HttpGet]
        public ActionResult urunekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult urunekle(string ad,string aciklama,int katID,decimal fiyat,string fotolink)
        {
            tblUrun u = new tblUrun();
            u.urunAciklama = aciklama;
            u.urunAd = ad;
            u.kategoriID = katID;
            u.fiyat = fiyat;
            u.fotolink = fotolink;
            u.kullaniciID =Convert.ToInt32( Session["id"].ToString());
            u.satildigiTarih = DateTime.Now;

            database.tblUrun.Add(u);
            database.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult profil()
        {
            Kullanici k = new Kullanici();
            k.ad = Session["ad"].ToString();
            k.soyad = Session["soyad"].ToString();
            k.eposta = Session["eposta"].ToString();
            
            return View(k);
        }
    }
}