using System;
using System.Collections.Generic;
using System.Text;

namespace KuruyemisMagazisiTwo
{
    class Product : BaseProps, BaseMethods<Product>
    {
        public static List<Product> ProductList { get; set; } = new List<Product>();
        public string Name { get; set; }
        public double CostPrice { get; set; }
        public int TaxPercantage { get; set; }
        public int ProfitMargin { get; set; }
        public double Price { get; set; }
        public int Weight { get; set; }
        public int ShelfLife { get; set; } // raf ömrü
        public DateTime ShelfExpireTime { get; set; } // raf ömrü bitiş süresi

        public Product(string _name,
            double _costPrice,
            int _weight,
            int _shelfLife,
            int _profitMargin = 30,
            int _taxPercantage = 18)
        {
            Name = _name;
            CostPrice = _costPrice;
            Weight = _weight;
            ShelfLife = _shelfLife;
            ProfitMargin = _profitMargin;
            TaxPercantage = _taxPercantage;

            ShelfExpireTime = CreatedTime.AddDays(_shelfLife);
            Price = calculatePrice(_costPrice,
                _taxPercantage, _profitMargin);
        }

        public static void Add(Product item)
        {
            ProductList.Add(item);
        }

        public static void Delete(Product item)
        {
            throw new NotImplementedException();
        }

        public static void List()
        {
            throw new NotImplementedException();
        }

        public static void  Update(int id)
        {
            throw new NotImplementedException();
        }

        public double calculatePrice(double maliyetFiyati,
            int vergi, int karOrani)
        {
            double vergilifiyat = (vergi * maliyetFiyati) / 100;
            double karliFiyati = (karOrani * maliyetFiyati) / 100;
            double toplamFiyat = maliyetFiyati + vergilifiyat + karliFiyati;

            return toplamFiyat;
        }

        public static void urunEkleCase()
        {
            Console.Write("Ürün adı:");
            string productName = Console.ReadLine();

            Console.Write("Maliyet Fiyatı:");
            double costPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Vergi Oranı:");
            int taxPercentage = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kar Oranı:");
            int profitMargin = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ürün Toplam Ağırlığı:");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Raf Ömrü:");
            int shelfLife = Convert.ToInt32(Console.ReadLine());

            Product eklenecekUrun = new Product(productName,
                costPrice,
                weight,
                shelfLife,
                profitMargin,
                taxPercentage);

            Add(eklenecekUrun);
        }
    }
}
