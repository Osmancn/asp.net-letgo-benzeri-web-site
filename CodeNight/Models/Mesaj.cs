using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeNight
{
    public class Mesaj
    {
        public int aliciID { get; private set; }
        public int gondericiID { get; private set; }
        public string mesaj { get; private set; }
        public DateTime tarih { get; private set; }

        public Mesaj(int aID,int gID,string mesaj,DateTime tarih)
        {
            aliciID = aID;
            gondericiID = gID;
            this.mesaj = mesaj;
            this.tarih = tarih;
        }

    }
}