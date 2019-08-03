using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas3
{
    class Lingkaran : Persegi
    {
        public override void persegi()
        {
            Console.Write("Masukkan jari jari lingkaran = ");
            double r = Convert.ToInt32(Console.ReadLine());
            double phi = 3.14;
            double luas = phi * r * r;
            double keliling = 2 * phi * r;
            Console.Write("Maka Luas lingkaran = " + luas);
            Console.ReadLine();
            Console.Write("Maka Keliling lingkaran = " + keliling);
            Console.ReadLine();

        }
    }
}
