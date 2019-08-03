using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas3
{
    class Persegi
    {
        public double panjang;
        public double lebar;
        public double luas, keliling;


        public virtual void persegi()
        {
            Console.Write("Masukkan nilai panjang = ");
            panjang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai lebar = ");
            lebar = Convert.ToInt32(Console.ReadLine());
            luas = panjang * lebar;
            keliling = 2 * (panjang + lebar);
            Console.Write("Maka Luas Persegi  = " + luas);
            Console.ReadLine();
            Console.Write("Maka Keliling Persegi  = " + keliling);
            Console.ReadLine();

            


        }
    }
}
