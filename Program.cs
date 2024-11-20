using System;

ilk ödev
using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        
        int fark = sayi1 - sayi2;
        Console.WriteLine($"İki sayının farkı: {fark}");
    }
}

ikinci ödev
using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        double sayi = Convert.ToDouble(Console.ReadLine());
        double kare = sayi * sayi;
        Console.WriteLine($"Girdiğiniz sayının karesi: {kare}");
    }



    üçüncü ödev
using System;

class Program
{
    static void Main()
    {
        int sayi = 10;
        int bolen = 3;
        int kalan = sayi % bolen;
        Console.WriteLine($"{sayi} sayısının {bolen} ile bölümünden kalan: {kalan}");
    }
}



dördüncü ödev
using System;

class Program
{
    static void Main()
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Üçüncü sayıyı girin: ");
        int sayi3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Dördüncü sayıyı girin: ");
        int sayi4 = Convert.ToInt32(Console.ReadLine());

        
        int toplam = sayi1 + sayi2 + sayi3 + sayi4;
        int carpim = sayi1 * sayi2 * sayi3 * sayi4;

        
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
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());
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
