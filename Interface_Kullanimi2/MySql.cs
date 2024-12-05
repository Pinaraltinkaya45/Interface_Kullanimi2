using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Kullanimi2
{
    public class MySql : IMusteri
    {
        public void ekle()
        {
            Console.WriteLine("MySql ekledi");
        }

        public void guncelle()
        {
            Console.WriteLine("MySql güncelledi");
        }

        public void sil()
        {
            Console.WriteLine("MySql sildi");
        }
    }
}
