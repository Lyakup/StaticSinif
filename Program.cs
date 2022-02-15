using System;

namespace StaticSinif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı :" + Calisan.calisanSayisi);

            Calisan calisan1 = new Calisan("Berkan", "Layık");
            Console.WriteLine("Çalışan Sayısı :" + Calisan.calisanSayisi);

            Console.WriteLine("Toplama Sonucu : " + Islemler.Topla(20, 22));
        }
    }

    class Calisan
    {

        private string Isim;
        private string Soyisim;
        
        public static int calisanSayisi;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static int Topla(int x, int y)
        {
            return x + y;
        }
    }
}
