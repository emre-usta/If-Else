using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time>=6 && time<11)
                Console.WriteLine("Günaydın!");
            else if(time<=18)
                Console.WriteLine("İyi Günler!");
            else 
                Console.WriteLine("İyi Geceler!");

            // string sonuc = time<=18 ? "İyi günler" : "İyi Geceler";

            string sonuc = time>=6 && time<11 ? "Günaydın!" : time<=18 ? "İyi günler!" : "İyi Geceler!";
            Console.WriteLine(sonuc);

            // switch

            int mounth = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                Console.WriteLine("Ocak ayındayız");
                break;
                case 2:
                Console.WriteLine("şubat ayındayız");
                break;
                case 4:
                Console.WriteLine("temmuz ayındayız");
                break;
                case 3:
                Console.WriteLine("mart ayındayız");
                break;
                default:
                Console.WriteLine("YAnlış veri girdiniz");
            }
        }   
    }
}