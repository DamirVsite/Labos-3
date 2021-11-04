using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratnaJednadzba
{
    class QuadraticEquation
    {
        public QuadraticEquation()
        {
        }

        // konstruktor je public jer su abc private
        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c; // Kao self u pythonu
        }

        public double A // Ovo su svojstva - kao da direktno pristupa članu
                        // get, set metode najčešće
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public double C
        {
            get { return c; }
            set { c = value; }
        }

        // za zadano x, vraća y:

        public double Y(double x)
        {
            return a * x * x + b * x + c;
        }

        // svojstvo vraća diskriminantu:
        public double Diskriminanta
        {
            get { return b * b - 4 * a * c; }
        }

        //r ješenja tj korijeni kv jedn:
        public double[] Roots
        {
            get

            {
                if (a == 0)
                {
                    return new double[] { -c / b, -c / b };
                }
                double sqrtDisc = Math.Sqrt(Diskriminanta);
                return new double[] { (-b - sqrtDisc) / 2 / a, (-b + sqrtDisc) / 2 / a };
            }
        }
        private double a;
        private double b;
        private double c;




    }
}

