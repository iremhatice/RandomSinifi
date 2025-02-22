namespace RandomSinifi_Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ornek2: Sınıftan rastgele ogrenci secen bir program. Secilen ogrenci tekrar secilemeyecek.

            // Öğrenci listesini oluştur
            List<string> ogrenciler = new List<string> { "Eren", "Irem", "Emriye", "Murat", "Hatice", "Mustafa", "Milena", "Helen" };
            Random random = new Random();

            while (ogrenciler.Count > 0) // Liste boşalana kadar devam et
            {
                Console.WriteLine("Enter'a basarak rastgele bir öğrenci seçin...");
                Console.ReadLine(); // Kullanıcı Enter'a basana kadar bekler

                // ogrenciler listesinden rastgele bir öğrenci seç
                int index = random.Next(ogrenciler.Count);
                string secilenOgrenci = ogrenciler[index];

                // Seçilen öğrenciyi ekrana yazdır
                Console.WriteLine($"Seçilen öğrenci: {secilenOgrenci}");

                // Seçilen öğrenciyi listeden kaldır
                ogrenciler.RemoveAt(index);

                // Eğer tüm öğrenciler seçildiyse oyunu bitir
                if (ogrenciler.Count == 0)
                {
                    Console.WriteLine("Tüm öğrenciler seçildi. Oyun bitti!");
                }
            }
        }
    }
}
