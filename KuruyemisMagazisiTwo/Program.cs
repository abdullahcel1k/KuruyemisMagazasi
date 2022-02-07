using System;

namespace KuruyemisMagazisiTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim = 0;
            while (secim != 8)
            {
                Console.WriteLine("1 - Ürün Ekle");
                Console.WriteLine("2 - Ürün Silme");
                Console.WriteLine("3 - Ürün Güncelleme"); // öğrenciler yapıcak
                Console.WriteLine("4 - Ürün Satış");
                Console.WriteLine("5 - Ürün Listeleme");
                Console.WriteLine("6 - Ürün Ara"); // öğrencilere bırakıldı
                Console.WriteLine("7 - Kasa Haraketleri");
                Console.WriteLine("8 - Çıkış");
                secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Product.urunEkleCase();

                        break;
                    case 2:
                    default:
                        break;
                }
            }
        }
    }
}
