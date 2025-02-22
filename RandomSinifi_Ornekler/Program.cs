namespace RandomSinifi_Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ornek1 :Bilgisayarın tuttuğu 1-100 arasındaki rastgele sayıyı kullanıcıdan alan ve karşılaştıran 10 tahmin hakkı veren ve kullanıcı sayıyı doğru tahmin ettiğinde kaçıncı tahminde bulduğunu ekrana yazan program.10 hak bittiğinde tahmin edememişse kullanıcıya olumsuz mesaj döndüren girdiği sayıya göre yönlendirme yapan programı yazınız.

            Random random = new Random();
            int a = random.Next(1, 101);
            int sayac = 1;
            Console.WriteLine("********SAYI TAHMİN OYUNU**********");

        sayi:
            Console.Write("Lütfen bir sayı giriniz: ");
            string giris = Console.ReadLine();

            // Sayı kontrolü
            if (!int.TryParse(giris, out int sayi))
            {
                Console.WriteLine("Hatalı giriş! Lütfen sadece bir sayı giriniz.");
                goto sayi; // Geçersiz girişte tekrar giriş istemek için
            }

            if (sayac < 10)
            {
                if (sayi == a)
                {
                    Console.WriteLine($"TEBRİKLER! {sayac} tahminde bildiniz.");
                }
                else if (sayi < a)
                {
                    Console.WriteLine("Sayıyı arttırınız.");
                    sayac++;
                    goto sayi;
                }
                else if (sayi > a)
                {
                    Console.WriteLine("Sayıyı azaltınız.");
                    sayac++;
                    goto sayi;
                }
            }
            else
            {
                Console.WriteLine("10 tahmin hakkını kullandınız doğru bilemediniz.");
            }

        }
    }
}
