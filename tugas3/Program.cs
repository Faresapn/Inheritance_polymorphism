using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas3
{
    class Program
    {
        static void Main(string[] args)
        {
        Volume:
            Console.WriteLine("Rumus Untuk Menghitung Keliling dan luas Bangun Datar");
            Console.WriteLine("1.Persegi");
            Console.WriteLine("2.Persegi panjang");
            Console.WriteLine("3.Segitiga sama sisi");
            Console.WriteLine("4.Lingkaran");
            Console.Write("Pilihlah Salah Satu Bangun Datar Di atas : ");
            int a = Convert.ToInt16(Console.ReadLine());
            switch (a)
            {
                case 1:

                    Persegi persegi1 = new Persegi();
                    persegi1.persegi();
                    Console.ReadLine();

                    break;
                case 2:
                    Persegipanjang persegip = new Persegipanjang();
                    persegip.persegi();
                    Console.ReadLine();
                    break;

                case 3:
                    Segitiga segitiga = new Segitiga();
                    segitiga.persegi();
                    Console.ReadLine();
                    break;
         
                case 4:
                    Lingkaran ling = new Lingkaran();
                    ling.persegi();
                    Console.ReadLine();
                    break;



            }

            Console.Write("Ingin Coba Lagi? Y/N ");
            String pilihan = (Console.ReadLine());
            switch (pilihan)
            {
                case "Y":
                    Console.Clear();
                    goto Volume;

                case "N":
                    break;

                case "y":
                    Console.Clear();
                    goto Volume;

                case "n":
                    break;
            }

        }
    
    }
}
