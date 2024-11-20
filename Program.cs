using System;

ilk ödev
using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan iki sayı al
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        // Farkı hesapla
        int fark = sayi1 - sayi2;

        // Sonucu ekrana yazdır
        Console.WriteLine($"İki sayının farkı: {fark}");
    }
}

ikinci ödev
using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan bir sayı al
        Console.Write("Bir sayı girin: ");
        double sayi = Convert.ToDouble(Console.ReadLine());

        // Sayının karesini hesapla
        double kare = sayi * sayi;

        // Sonucu ekrana yazdır
        Console.WriteLine($"Girdiğiniz sayının karesi: {kare}");
    }



    üçüncü ödev
using System;

class Program
{
    static void Main()
    {
        // Bölünecek sayıyı tanımla
        int sayi = 10;
        int bolen = 3;

        // Kalanı hesapla
        int kalan = sayi % bolen;

        // Sonucu ekrana yazdır
        Console.WriteLine($"{sayi} sayısının {bolen} ile bölümünden kalan: {kalan}");
    }
}



dördüncü ödev
using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan 4 sayı al
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Üçüncü sayıyı girin: ");
        int sayi3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Dördüncü sayıyı girin: ");
        int sayi4 = Convert.ToInt32(Console.ReadLine());

        // Toplamı ve çarpımı hesapla
        int toplam = sayi1 + sayi2 + sayi3 + sayi4;
        int carpim = sayi1 * sayi2 * sayi3 * sayi4;

        // Sonuçları ekrana yazdır
        Console.WriteLine($"Girilen sayıların toplamı: {toplam}");
        Console.WriteLine($"Girilen sayıların çarpımı: {carpim}");
    }
}



beşinci ödev
using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan iki sayı al
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        // Bölümü hesapla ve kontrol et
        if (sayi2 != 0)
        {
            double bolum = sayi1 / sayi2;
            Console.WriteLine($"Girilen sayıların bölümü: {bolum}");
        }
        else
        {
            Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz.");
        }
    }
}