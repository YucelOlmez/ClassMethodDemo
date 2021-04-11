using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Console.WriteLine("Lütfen TC Kimlik Numaranızı Giriniz !");
            musteri1.tc = Console.ReadLine();
            Console.WriteLine("Adınız Giriniz !");
            musteri1.adi = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz !");
            musteri1.soyadi = Console.ReadLine();
            Console.WriteLine("Yaşınızı Giriniz !");
            musteri1.yas = Convert.ToByte(Console.ReadLine());

            Musteri musteri2 = new Musteri();
            musteri2.tc = "99999999999";
            musteri2.adi = "Michael";
            musteri2.soyadi = "Schumacher";
            musteri2.yas = 51;


            Musteri musteri3 = new Musteri();
            musteri3.tc = "88888888888";
            musteri3.adi = "James";
            musteri3.soyadi = "Hetfield";
            musteri3.yas = 65;

            Musteri musteri4 = new Musteri();
            musteri4.tc = "77777777777";
            musteri4.adi = "Paul";
            musteri4.soyadi = "Walker";
            musteri4.yas = 38;

            Musteri[] newCredit = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            Console.WriteLine("Kredisi Onaylananlar Listesi");
            foreach (Musteri customList in newCredit)
            {
                Console.WriteLine(customList.tc + " " + customList.adi + " " + customList.soyadi + " " + customList.yas);
            }




            ArrayList custDeleteList = new ArrayList();


            for (int i = 0; i < 4; i++)
            {
                custDeleteList.Add(i);
            }
            custDeleteList.Add(musteri1);
            custDeleteList.Add(musteri2);
            custDeleteList.Add(musteri3);
            custDeleteList.Add(musteri4);

            
        }
    }
}
