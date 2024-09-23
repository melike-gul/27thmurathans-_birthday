namespace Happy_Birthday;

using System;
using System.Collections.Generic;

class Program
{
    public class Kisi
    {
        public string Ad { get; set; }
        public DateTime DogumTarihi { get; set; }
    }

    static void Main()
    {
        List<Kisi> kisiler = new List<Kisi>
        {
            new Kisi { Ad = "Murathan Saygılı", DogumTarihi = new DateTime(1997, 9, 23) }
        };

        DateTime bugun = DateTime.Now;

        foreach (var kisi in kisiler)
        {
            if (kisi.DogumTarihi.Month == bugun.Month && kisi.DogumTarihi.Day == bugun.Day)
            {
                Console.WriteLine($"Doğum Günün Kutlu Olsun {kisi.Ad}!");
            }
        }
    }
}

