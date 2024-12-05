using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Kullanimi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusteriController mustericontroller = new MusteriController();
            mustericontroller.musteriEkle(new MySql());
            mustericontroller.musteriEkle(new SqlServer());

            Console.ReadLine();


        }
    }
}
