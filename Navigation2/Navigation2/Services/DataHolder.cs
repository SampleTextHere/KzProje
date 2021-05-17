using Navigation2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Navigation2.Services
{
    public static class DataHolder
    {
        private static Random random;
        public static Product GetRandomProduct()
        {
            return Products[random.Next(0, Products.Count)];
        }
        public static ObservableCollection<Product> Products { get; set; }

        public static ObservableCollection<Product> GetProductsByCategory(string category)
        {
            ObservableCollection<Product> filteredList = new ObservableCollection<Product>();
            foreach (Product product in Products)
            {
                if (product.Category == category)
                {
                    filteredList.Add(product);
                }
            }
            return filteredList;
        }

        public static ObservableCollection<Product> GetProductsByRandom(int count)           
        {
            if (count > Products.Count) count = Products.Count;
            ObservableCollection<Product> randomList = new ObservableCollection<Product>();
            for (int i = 0; i < count; i++)
            {
                bool repeat;
                Product randomProduct;
                do
                {
                    repeat = false;
                    randomProduct = GetRandomProduct();
                    foreach (Product product in randomList)
                    {
                        if (product == randomProduct)
                        {
                            repeat = true;
                        }
                    }

                } while (repeat);
                randomList.Add(randomProduct);
            }
            return randomList;
        }



        static DataHolder()
        {
            random = new Random();
            Products = new ObservableCollection<Product>();
            Products.Add(new Product
            {
                Name = "KZ ZSN Pro 1BA+1DD Hibrit Kulaklık",
                Model = "KZ ZSN Pro",
                Category = "kulaklık",
                Image = "KZ_ZSN_Pro",
                Views = 5,
                NoDiscount = 229.9f,
                Price = 189.9f,
                Description = "KZ ZSN Pro 1BA+1DD Dengeli Armatür ve" +
                  "Dinamik Sürücü Hibrit, HD Mikrofonlu," +
                   " Gürültü Azaltıcı Kulak İçi Kulaklık"
            });

            Products.Add(new Product
            {
                Name = "KZ ZS10 Pro 4BA+1DD Hibrit Kulaklık",
                Model = "KZ ZS10 Pro",
                Category = "kulaklık",
                Image = "KZ_ZS10_Pro",
                Views = 5,
                NoDiscount = 519.9f,
                Price = 399.9f,
                Description = "KZ ZS10 Pro 4BA+1DD 4 Dengeli Armatür ve" +
                " 1 Dinamik Sürücü Hibrit, HD Mikrofonlu," +
                " Gürültü Azaltıcı Kulak İçi Kulaklık"
            });

            Products.Add(new Product
            {
                Name = "KZ ZSX Terminator 5BA+1DD Hibrit Kulaklık",
                Model = "KZ ZSX",
                Category = "kulaklık",
                Image = "KZ_ZSX",
                Views = 5,
                NoDiscount = 579.9f,
                Price = 439.9f,
                Description = "KZ ZSX Terminator 5BA+1DD 5 Dengeli Armatür ve" +
                " 1 Dinamik Sürücü Hibrit, HD Mikrofonlu," +
                " Gürültü Azaltıcı Kulak İçi Kulaklık"
            });

            Products.Add(new Product
            {
                Name = "KZ ZST Pro 1BA+1DD Hibrit Kulaklık",
                Model = "KZ ZST Pro",
                Category = "kulaklık",
                Image = "KZ_ZST_Pro",
                Views = 5,
                NoDiscount = 229.9f,
                Price = 189.9f,
                Description = "KZ ZST Pro 1BA+1DD Dengeli Armatür ve" +
                " Dinamik Sürücü Hibrit Yüksek Bas Özellikli," +
                " HD Mikrofonlu, Gürültü Azaltıcı Kulakiçi Kulaklık"
            });

            Products.Add(new Product
            {
                Name = "KZ ZSN Pro X 1BA+1DD Gümüş Kablolu Kulaklık",
                Model = "KZ ZSN Pro X",
                Category = "kulaklık",
                Image = "KZ_ZSN_Pro_X",
                Views = 5,
                NoDiscount = 229.9f,
                Price = 199.9f,
                Description = "KZ ZSN Pro X 10mm Dinamik bas sürücü ve" +
                " 30095 BA Denge Armatürü Hibrit Yüksek Bas," +
                " Gümüş Kablolu Kulakiçi Kulaklık"
            });

            Products.Add(new Product
            {
                Name = "KZ ZS3 1DD Yüksek Bass Kulaklık",
                Model = "KZ ZS3",
                Category = "kulaklık",
                Image = "KZ_ZS3",
                Views = 5,
                NoDiscount = 149.9f,
                Price = 109.9f,
                Description = "KZ ZS3 1DD Dinamik Sürücü, HiFi Yüksek Bass," +
                " HD Mikrofonlu, Gürültü Azaltıcı Kulak İçi Kulaklık"
            });

            Products.Add(new Product
            {
                Name = "QKZ VK4 Dinamik Sürücü Kulak İçi Kulaklık",
                Model = "QKZ VK4",
                Category = "kulaklık",
                Image = "QKZ_VK4",
                Views = 5,
                NoDiscount = 169.9f,
                Price = 129.9f,
                Description = "QKZ VK4 1DD Güçlü Dinamik Sürücü, HiFi Yüksek Bass, Mikrofonlu Kulak İçi Kulaklık"
            });

            Products.Add(new Product
            {
                Name = "KZ ES4 1BA+1DD Kulak İçi Kulaklık",
                Model = "KZ_ES4",
                Category = "kulaklık",
                Image = "KZ_ES4",
                Views = 5,
                NoDiscount = 219.9f,
                Price = 179.9f,
                Description = "KZ ES4 1BA+1DD Dengeli Armatür ve Dinamik Sürücü Hibrit, HD Mikrofonlu, Gürültü Azaltıcı Kulak İçi Kulaklık"
            });

            Products.Add(new Product
            {
                Name = "KZ ZST X 1BA+1DD Gümüş Kablolu Kulaklık",
                Model = "KZ ZST X",
                Category = "kulaklık",
                Image = "KZ_ZST_X",
                Views = 5,
                NoDiscount = 229.9f,
                Price = 209.9f,
                Description = "KZ ZSTX 1BA+1DD Denge Armatür ve XUN Dinamik Sürücü Hibrit Yüksek Bas, Gümüş Kablolu Kulakiçi Kulaklık"
            });

            Products.Add(new Product
            {
                Name = "KZ ATR 1DD Dinamik Sürücü Bas Kulaklık",
                Model = "KZ ATR",
                Category = "kulaklık",
                Image = "KZ_ATR",
                Views = 5,
                NoDiscount = 129.9f,
                Price = 89.9f,
                Description = "KZ ATR 1DD Dinamik Sürücü, HiFi Yüksek Bas, HD Mikrofonlu, Gürültü Azaltıcı Kulak İçi Kulaklık"
            });

            Products.Add(new Product
            {
                Name = "KZ EDX 1DD Mikrofonlu Kulak İçi Kulaklık",
                Model = "KZ EDX",
                Category = "kulaklık",
                Image = "KZ_EDX",
                Views = 5,
                NoDiscount = 159.9f,
                Price = 109.9f,
                Description = "KZ EDX Kompozit 1DD Dinamik Sürücü, HiFi Yüksek Bass, Mikrofonlu, Kulak İçi Kulaklık"
            });

            Products.Add(new Product
            {
                Name = "KZ ED12 1DD Dinamik Sürücü Bas Kulaklık",
                Model = "KZ ED12",
                Category = "kulaklık",
                Image = "KZ_ED12",
                Views = 5,
                NoDiscount = 139.9f,
                Price = 119.9f,
                Description = "KZ ED12 1DD Dinamik Sürücü, HiFi Yüksek Bas, HD Mikrofonlu, Gürültü Azaltıcı Kulakiçi Kulaklık"
            });

            Products.Add(new Product
            {
                Name = "KZ ZAX 7BA+1DD Hibrit Kulak İçi Kulaklık",
                Model = "KZ ZAX",
                Category = "kulaklık",
                Image = "KZ_ZAX",
                Views = 5,
                NoDiscount = 699.9f,
                Price = 689.9f,
                Description = "KZ ZAX 7 adet BA Denge Armatürü ve 10mm çift manyetik dinamik bas sürücü, Gümüş Kablolu Kulak İçi Kulaklık"
            });

            Products.Add(new Product
            {
                Name = "KZ DQ6 3DD 3 Dinamik Sürücü Kulak İçi Kulaklık",
                Model = "KZ DQ6",
                Category = "kulaklık",
                Image = "KZ_DQ6",
                Views = 5,
                NoDiscount = 259.9f,
                Price = 239.9f,
                Description = "KZ DQ6 3DD 3 Adet Dinamik Sürücü Gümüş Kablolu Kulak İçi Kulaklık"
            });

            Products.Add(new Product
            {
                Name = "QKZ AK6 Yüksek Bas Mikrofonlu Kulak İçi Kulaklık",
                Model = "QKZ AK6",
                Category = "kulaklık",
                Image = "QKZ_AK6",
                Views = 5,
                NoDiscount = 99.9f,
                Price = 79.9f,
                Description = "QKZ AK6 1DD Dinamik Sürücü, HiFi Yüksek Bas, Mikrofonlu Kulak İçi Kulaklık"
            });

            Products.Add(new Product
            {
                Name = "KZ ASF 5BA Denge Armatürlü Kulak İçi Kulaklık",
                Model = "KZ ASF",
                Category = "kulaklık",
                Image = "KZ_ASF",
                Views = 5,
                NoDiscount = 499.9f,
                Price = 469.9f,
                Description = "KZ ASF 5BA 5 adet Denge Armatür Sürücü Gümüş Kablolu Kulak İçi Kulaklık"
            });

            Products.Add(new Product
            {
                Name = "KZ ZSN, ZSN Pro, ZS10 Pro, ZSX, AS16, AS12, ASF, ASX, DQ6 Yedek Kablo",
                Model = "KZ C",
                Category = "kablo",
                Image = "KZ_C",
                Views = 0,
                NoDiscount = 74.9f,
                Price = 65.9f,
                Description = "KZ Pin C Kablo. KZ ZSN, ZSN Pro, ZSN Pro X, ZS10 Pro, ZSX Terminator," +
                " AS16, AS12, ASF, ASX, DQ6 modelleri ile uyumlu orijinal yedek kulaklık kablosu."
            });

            Products.Add(new Product
            {
                Name = "KZ ZST ZST Pro AS10 BA10 ES3 ES4 ZS10 AS06 ZSR Yedek Kablo",
                Model = "KZ B",
                Category = "kablo",
                Image = "KZ_B",
                Views = 0,
                NoDiscount = 74.9f,
                Price = 54.9f,
                Description = "KZ Pin B Kablo. ZST, ZST Pro, ZST X, AS10, BA10, ZS10(pro değil)," +
                " AS06, ES4, ED12, EDX, ZSR, ES3 modelleri ile uyumlu orijinal yedek kulaklık kablosu."
            });

            Products.Add(new Product
            {
                Name = "KZ Altın+Gümüş Kablo ZSN, ZSN Pro, ZS10 Pro, ZSX, ZAX, AS16, AS12, ASF, ASX, DQ6",
                Model = "ALTIN GUMUS C",
                Category = "kablo",
                Image = "ALTIN_GUMUS_C",
                Views = 0,
                NoDiscount = 149.9f,
                Price = 114.9f,
                Description = "KZ ZSN, ZSN Pro, ZSN Pro X, ZS10 Pro, ZSX Terminator," +
                " ZAX, AS16, AS12, ASF, ASX, DQ6 modelleri ile uyumlu Pin C altın+gümüş" +
                " yükseltme kablosu."
            });


            Products.Add(new Product
            {
                Name = "KZ Gümüş Kablo ZSN, ZSN Pro, ZS10 Pro, ZSX, ZAX, AS16, AS12, ASF, ASX, DQ6",
                Model = "GUMUS C",
                Category = "kablo",
                Image = "GUMUS_C",
                Views = 5,
                NoDiscount = 99.9f,
                Price = 89.9f,
                Description = "KZ ZSN, ZSN Pro, ZSN Pro X, ZS10 Pro, ZSX Terminator," +
        " ZAX, AS16, AS12, ASF, ASX, DQ6 modelleri ile uyumlu Pin C gümüş yükseltme kablosu"
            });
            Products.Add(new Product
            {
                Name = "KZ ZS3 ZS4 ZS5 ZS6 ZS7 ZSA ED16 Yedek Kablo",
                Model = "KZ A",
                Category = "kablo",
                Image = "KZ_A",
                Views = 5,
                NoDiscount = 74.9f,
                Price = 64.9f,
                Description = "KZ Pin A Kablo. ZS3, ZS4, ZS5, ZS6, ZS7, ZSA, " +
            "ED16 modelleri ile uyumlu orijinal yedek kulaklık kablosu."
            });
            Products.Add(new Product
            {
                Name = "KZ Gümüş Kablo ZST, ZST Pro, AS10, BA10, ES3, ES4, ZS10, AS06, ZSR",
                Model = "GUMUS B",
                Category = "kablo",
                Image = "GUMUS_B",
                Views = 5,
                NoDiscount = 99.9f,
                Price = 89.9f,
                Description = "KZ ZST, ZST Pro, ZST X, AS10, BA10, ZS10(pro değil), AS06, " +
            "ES4, ED12, EDX, ZSR, ES3 modelleri ile uyumlu Pin B gümüş yükseltme kablosu."
            });

            Products.Add(new Product
            {
                Name = "KZ Altın+Gümüş Kablo ZST, ZST Pro, AS10, BA10, ES3, ES4, ZS10, AS06, ZSR",
                Model = "ALTIN GUMUS B",
                Category = "kablo",
                Image = "ALTIN_GUMUS_B",
                Views = 5,
                NoDiscount = 149.9f,
                Price = 114.9f,
                Description = "KZ ZST, ZST Pro, ZST X, AS10, BA10, ZS10 (pro değil), AS06, ES4, ED12, EDX, " +
            "ZSR, ES3 modelleri ile uyumlu Pin B altın+gümüş yükseltme kablosu."
            });
            Products.Add(new Product
            {
                Name = "KZ Gümüş Kablo ZS3 ZS4 ZS5 ZS6 ZS7 ZSA ED16",
                Model = "GUMUS A",
                Category = "kablo",
                Image = "GUMUS_A",
                Views = 5,
                NoDiscount = 109.9f,
                Price = 89.9f,
                Description = "KZ ZS3, KZ ZS4, KZ ZS5, KZ ZS6, KZ ZS7, KZ ZS3E, KZ ZSA, KZ" +
            " ED16 modelleri ile uyumlu Pin A gümüş yükseltme kablosu."
            });


        }



    }
}
