namespace RandomSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region RandomSinifi
            //Random sınıfı, rastgele sayı üretmek için kullanılır. 
            /* Kullanım:
             * Oncelikle bir Random nesnesi olusturmalısın: Random random = new Random();
             * Next() metodu rastgele bir tam sayı (int) döndürür.
            */

            Random random = new Random();
            int sayi1 = random.Next(); // 0 ile int.MaxValue (2,147,483,647) arasında bir değer üretir.
            Console.WriteLine(sayi1);
            #endregion

            #region Ozel Aralikta Deger Uretmek
            //Ozel Aralıkta Deger Uretmek Için:
            Random random2 = new Random();
            int sayi2 = random2.Next(1, 101); // 1 ile 100 arasında bir sayı üretir (101 dahil değil!)
            Console.WriteLine(sayi2);

            //Önemli: random.Next(min, max) kullanırken max değeri dahil değildir.
            //1 - 10 arasında değer almak için:
            random2.Next(1, 11);
            #endregion

            #region NextDouble()
            //NextDouble() – 0.0 ile 1.0 Arasında Ondalık (Double) Uretir
            Random random3 = new Random();
            double ondalikSayi = random3.NextDouble(); // 0.0 ile 1.0 arasında rastgele sayı üretir
            Console.WriteLine(ondalikSayi);

            double genisAraliktaSayi = random3.NextDouble() * 50; // 0 ile 50 arasında bir sayı üretir
            Console.WriteLine(genisAraliktaSayi);
            #endregion

            #region NextBytes()
            //NextBytes() – Rastgele Byte Dizisi Üretir
            Random random4 = new Random();
            byte[] dizi = new byte[5];  // 5 elemanlı byte dizisi
            random.NextBytes(dizi);     // Her elemanı 0-255 arasında rastgele doldurur

            foreach (byte b in dizi)
            {
                Console.Write(b + " ");
            }
            //Örnek Çıktı: 123 45 78 200 156
            #endregion
      
            #region Random ile Rastgele Karakter, String veya Renk Uretmek
            //Rastgele Harf Uretme
            Random random5 = new Random();
            char harf = (char)random5.Next('A', 'Z' + 1); // A-Z arasında harf üretir
            Console.WriteLine(harf);

            //Rastgele String Uretme
            string RastgeleKelime(int uzunluk)
            {
                string harfler = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                char[] karakterDizisi = new char[uzunluk];

                for (int i = 0; i < uzunluk; i++)
                {
                    karakterDizisi[i] = harfler[random5.Next(harfler.Length)];
                }
                return new string(karakterDizisi);
            }

            Console.WriteLine(RastgeleKelime(5));
            //Ornek Cıktı: "aXyTz"

            //Rastgele Renk Uretme
            Random random6 = new Random();
            string RastgeleRenk()
            {
                int r = random6.Next(256);
                int g = random6.Next(256);
                int b = random6.Next(256);
                return $"RGB({r}, {g}, {b})";
            }

            Console.WriteLine(RastgeleRenk());
            //Ornek Cıktı: RGB(123, 45, 200)
            #endregion
        }
    }
}
