using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeNight.Models;

namespace CodeNight.Controllers
{
    public class HomeController : Controller
    {
        databasee database = new databasee();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string ad,string soyad,string eposta,string sifre)
        {
            tblKullanici k = new tblKullanici();
            k.ad = ad;
            k.soyad = soyad;
            k.eposta = eposta;
            k.sifre = sifre;

            database.tblKullanici.Add(k); 
            database.SaveChanges();

            return View();
        }

        


        
       
    }
}