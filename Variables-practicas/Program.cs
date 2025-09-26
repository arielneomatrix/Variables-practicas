using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_practicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;
            byte numero2 = (byte)numero;

            float numero3 = 300.02f;
            int numero4 = (int)numero3;

            Console.WriteLine(numero2);
            Console.WriteLine(numero4);


            ////
            ///
            string cadena = "10";
            int numero5 = int.Parse(cadena);
            int numero6 = Convert.ToInt32(cadena);
            float numero7 = float.Parse(cadena);
            float numero8 = Convert.ToSingle(cadena);


            Console.WriteLine(numero5);
            Console.WriteLine(numero6);
            Console.WriteLine(numero7);
            Console.WriteLine(numero8);

            int numero9 = 9000;
            numero9 += 500; // numero9 = numero9 + 500;
            Console.WriteLine(numero9);
            numero9 -= 200; // numero9 = numero9 - 200;
            Console.WriteLine(numero9);
            numero9 *= 2; // numero9 = numero9 * 2;
            Console.WriteLine(numero9);
            numero9 /= 4; // numero9 = numero9 / 4;
            Console.WriteLine(numero9);
            numero9 %= 3; // numero9 = numero9 % 3;
            Console.WriteLine(numero9);

            int gg = 5;
            gg++; // gg = gg + 1;
            Console.WriteLine(gg);

            int hh = 10;
            int ii = 5;
            int jj = 13;
            int kk = 7;

            Console.WriteLine(hh > ii); // true
            Console.WriteLine(hh < ii); // false
            Console.WriteLine(hh >= kk); // true
            Console.WriteLine(hh < kk && hh > jj); // false


        }
    }
}




            
