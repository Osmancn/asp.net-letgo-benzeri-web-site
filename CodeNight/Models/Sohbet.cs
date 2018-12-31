using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeNight
{
    public class Sohbet
    {
        public int karsiID { get; set; }
        public List<Mesaj> mesajlasmalar;

        public Sohbet(int id)
        {
            karsiID = id;
        }
        public void MesajEkle(List<Mesaj> m)
        {
            mesajlasmalar = m;
        }
    }
}