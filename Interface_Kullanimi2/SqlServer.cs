using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Kullanimi2
{
    public class SqlServer :IMusteri
    {
        public void ekle()
        {
            Console.WriteLine("Sql Server ekledi");
        }

        public void guncelle()
        {
            Console.WriteLine("Sql Server güncelledi");

        }

        public void sil()
        {
            Console.WriteLine("Sql Server sildi");
        }
    }
}
