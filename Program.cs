using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullanıcının_girdiği_sayıların_ortalaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adet Sayısını Giriniz: ");
            int adet = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            int sayi;
            for (int i = 0; i < adet; i++)
            {
                Console.Write("Sayı Giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
            }
            Console.WriteLine("Sayıların Ortalaması = " + (toplam / adet)); 
            Console.ReadLine();
            
        }
    }
}
