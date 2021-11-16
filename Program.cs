using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratnaJednadzba
{
    class Program
    {
        static void Main(string[] args)
        {

            QuadraticEquation qe = new QuadraticEquation(1, 2, -3);
            var roots = qe.Roots;
            Console.WriteLine(roots[0]);
            Console.WriteLine(roots[1]);
            Console.WriteLine("----------------");

            qe = new QuadraticEquation(-1, 2, -1);
            roots = qe.Roots;
            Console.WriteLine(roots[0]);
            Console.WriteLine(roots[1]);
            Console.WriteLine("----------------");
            // qe.a neće raditi jer je a definiran kao private!
            Console.WriteLine(qe.A);
            // qe.A = 10; - neće raditi jer je A svojstvo koje nema Set metodu!
            // nakon što stavimo, radi:
            qe.A = 15;
            Console.ReadKey();

        }
    }
}
