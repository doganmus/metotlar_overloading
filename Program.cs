using System;

namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }else{
                Console.WriteLine("Başarısız");
            }
            
            Metotlar intance =new Metotlar();
            intance.Topla(4,5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            //metot aşırı yükleme - overloading

            int ifade=999;
            intance.EkranaYazdir(ifade);
            intance.EkranaYazdir("Zikriye","Ürkmez");
            //metot imzası
            //metotAdi + parametre sayısı + parametre
        }
    }
    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
         public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

         public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }
}
