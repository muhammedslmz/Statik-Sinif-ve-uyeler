using System;
namespace statik_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string []args)
        {
            Console.WriteLine("Çalışan sayısı: {0}",Calisan.CalisanSayisi);
            Calisan user1=new Calisan("Muhammed","Solmaz","IT");
            Calisan user2=new Calisan("İkbal","Kıyatsıl","Muhasebe");
            Console.WriteLine("Çalışan sayısı: {0}",Calisan.CalisanSayisi);

            
            Console.WriteLine("Toplama işlemi sonucu: {0}",Islemler.Topla(156,526));
            Console.WriteLine("Çıkarma işleminin sonucu: {0}",Islemler.Çıkar(345,124));
        }
    }
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}
        
        

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi=0;
        }
        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi ++;
        }
    }
    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long Çıkar(int sayi1, int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}