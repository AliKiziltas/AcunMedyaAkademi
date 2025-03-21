namespace NumberGuessingGame;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int rastgeleSayi = random.Next(1, 101);
        int tahminSayisi= 0;
        int guessCount = 0;

        Console.WriteLine("Bilgisayar 1 ile 100 arasında bir sayı tuttu. Tahmin et bakalım!");

        while (tahminSayisi != rastgeleSayi)
        {
            Console.Write("Tahmininiz: ");
            try
            {
                tahminSayisi = Convert.ToInt32(Console.ReadLine());
                guessCount++;

                if (tahminSayisi < 1 || tahminSayisi > 100)
                {
                    Console.WriteLine("Lütfen 1 ile 100 arasında bir sayı girin.");
                    continue;
                }

                if (tahminSayisi < rastgeleSayi)
                {
                    Console.WriteLine("Daha büyük bir sayı girin.");
                }
                else if (tahminSayisi > rastgeleSayi)
                {
                    Console.WriteLine("Daha küçük bir sayı girin.");
                }
            }
            catch
            {
                Console.WriteLine("Lütfen geçerli bir sayı girin!");
            }
        }

        Console.WriteLine($"Tebrikler! {guessCount}. tahminde doğru sayıyı buldunuz.");
    }
}