using System;

class Program
{
    static double HesaplaUcgenAlani()
    {
        Console.Write("Üçgenin taban uzunluğunu girin: ");
        double taban = Convert.ToDouble(Console.ReadLine());

        Console.Write("Üçgenin yüksekliğini girin: ");
        double yukseklik = Convert.ToDouble(Console.ReadLine());

        double alan = (taban * yukseklik) / 2;
        return alan;
    }

    static void Main(string[] args)
    {
        double ucgenAlani = HesaplaUcgenAlani();
        Console.WriteLine("Üçgenin alanı: " + ucgenAlani);
    }
}

using System;

class Program
{
    static void Main()
    {
        
        int[] sayilar = { 10, 25, 7, 40, 15 };

        int enBuyukDeger = EnBuyukDegeriBul(sayilar);
        Console.WriteLine("Dizideki en büyük değer: " + enBuyukDeger);
    }
    static int EnBuyukDegeriBul(int[] dizi)
    {
        int enBuyuk = dizi[0];

        foreach (int sayi in dizi)
        {
            if (sayi > enBuyuk;
                 {
                enBuyuk = sayi;
            }
        }

        using System;

class Program
    {
        static int CalculateSum(int a, int b)
        {
            return a + b;
        }
        static double CalculateSum(double a, double b)
        {
            return a + b;
        }
        static int CalculateSum(int a, int b, int c)
        {
            return a + b + c;
        }

        static void Main()
        {
            
            Console.WriteLine("İki int sayının toplamı: " + CalculateSum(3, 5)); // int + int
            Console.WriteLine("İki double sayının toplamı: " + CalculateSum(3.5, 5.2)); // double + double
            Console.WriteLine("Üç int sayının toplamı: " + CalculateSum(1, 2, 3)); // int + int + int
        }
    }


    def fibonacci(n):
    # Fibonacci dizisinin ilk iki elemanı: 0 ve 1
    if n <= 1:
        return n
    else:
        return fibonacci(n-1) + fibonacci(n-2)


        using System;

class Program
{
    static double OrtalamaHesapla(params double[] sayilar)
    {
        if (sayilar.Length == 0)
        {
            throw new ArgumentException("En az bir sayı girmelisiniz.");
        }
        double toplam = 0;
        foreach (var sayi in sayilar)
        {
            toplam += sayi;
        }
        return toplam / sayilar.Length;
    }

    static void Main()
    {
        try
        {
            double ortalama = OrtalamaHesapla(10.5, 20.3, 30.7, 40.2);
            Console.WriteLine("Ortalama: " + ortalama);




            using System;

class Program
    {
        static int Topla(int[] dizi, int filtre)
        {
            int toplam = 0;
            foreach (int eleman in dizi)
            {
                if (eleman > filtre)
                {
                    toplam += eleman; 
                }
            }

            return toplam;  
        }

        static void Main()
        {
            int[] dizi = { 1, 5, 10, 3, 7, 8 };  
            int filtre = 4;  

            int sonuc = Topla(dizi, filtre);  

            Console.WriteLine("Filtre değerinden büyük elemanların toplamı: " + sonuc);
        }
    }





    def yas_farki(yas= 18):
    return yas - 18

kullanım:
print(yas_farki(25))  : 7




        using System;
using System.Collections.Generic;

class Program
    {
        static List<string> FiltreleUzunElemanlar(string[] dizi)
        {
            List<string> sonuc = new List<string>();

            foreach (string eleman in dizi)
            {
                if (eleman.Length > 5)
                {
                    sonuc.Add(eleman);
                }
            }

            return sonuc;
        }

        static void Main()
        {
            string[] dizi = { "apple", "banana", "kiwi", "strawberry", "pear" };

            List<string> uzunElemanlar = FiltreleUzunElemanlar(dizi);
            foreach (var eleman in uzunElemanlar)
            {
                Console.WriteLine(eleman);
            }
        }
    }

    print(yas_farki())  : 0



