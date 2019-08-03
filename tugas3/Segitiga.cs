using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas3
{
    class Segitiga : Persegi
    {
        public override void persegi()
        {
            Console.Write("Masukkan nilai alas = ");
           double alas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai tinggi = ");
           double tinggi = Convert.ToInt32(Console.ReadLine());
            luas = 1 / 2.0 * alas * tinggi;
            keliling = 3 * alas;
            Console.Write("Maka Luas PSegitiga = " + luas);
            Console.ReadLine();
            Console.Write("Maka Keliling Segitiga = " + keliling);
            Console.ReadLine();

        }
    }
}
