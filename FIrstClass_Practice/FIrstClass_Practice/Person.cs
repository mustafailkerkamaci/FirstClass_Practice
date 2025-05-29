using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIrstClass_Practice
{
    internal class Person
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        public void Bilgiler() 
        {
            Console.WriteLine("Ad: " + Ad);
            Console.WriteLine("Soyad: " + Soyad);
            Console.WriteLine("Doğum Tarihi: " + DogumTarihi.ToShortDateString()); // ToSohrtDateString() sadece tarihi gösterir, saat bilgisi yoktur.
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

    }
}
