using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Kullanimi2
{
    public class MusteriController
    {

        public void musteriEkle(IMusteri veritabani)
        {
            veritabani.ekle();
        }
    }
}
