using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work1
{
    class Program
    {
        static void Main(string[] args)
        {
            urun urun1 = new urun();
            urun1.urunAdi = "Mont";
            urun1.urunKalitesi = "orta";
            urun1.urunRengi = "mor";
            urun1.urunMevsimsel = "kışlık";
            urun1.urunFiyatı = 290;

            urun urun2 = new urun();
            urun2.urunAdi = "hoodie";
            urun2.urunKalitesi = "yüksek";
            urun2.urunRengi = "mavi";
            urun2.urunMevsimsel = "sonbahar";
            urun2.urunFiyatı = 90;

            urun urun3 = new urun();
            urun3.urunAdi = "şort";
            urun3.urunKalitesi = "düşük";
            urun3.urunRengi = "beyaz";
            urun3.urunMevsimsel = "yazlık";
            urun3.urunFiyatı = 30;

            urun urun4 = new urun();
            urun4.urunAdi = "bootie";
            urun4.urunKalitesi = "yüksek";
            urun4.urunRengi = "siyah";
            urun4.urunMevsimsel = "kışlık";
            urun4.urunFiyatı = 300;

            urun urun5 = new urun();
            urun5.urunAdi = "t-shirt";
            urun5.urunKalitesi = "orta";
            urun5.urunRengi = "bej";
            urun5.urunMevsimsel = "yazlık";
            urun5.urunFiyatı = 30;

            urun[] urunListesi = new urun[] { urun1, urun2, urun3, urun4, urun5 };

         /* for (int i = 0; i < urunListesi.Length; i++)
            {
                Console.WriteLine(urunListesi[i].urunAdi+urunListesi[i].urunFiyatı+urunListesi[i].urunKalitesi+urunListesi[i].urunMevsimsel+urunListesi[i].urunRengi);
            } */



           foreach (var urun in urunListesi)
            {
                Console.WriteLine("====>" +urun.urunAdi+"," +urun.urunKalitesi+ "," +urun.urunFiyatı+ "," +urun.urunMevsimsel+ "," +urun.urunRengi);
            }
            Console.WriteLine(" ");

            Console.ReadKey();
        }
    }

    
}
