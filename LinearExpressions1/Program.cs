using System;
using System.Text;

namespace LinearExpressions1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double a, b, c, d, x, y, z, r, x1, x2, y1, z1;

            Console.Write("Введіть число а=");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть число b=");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть число c=");
            c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть число d=");
            d = Convert.ToDouble(Console.ReadLine());

            x1 = Math.Pow(a, 2);
            x2 = Math.Pow(b, 2);

            x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - (x1 / x2);
            Console.WriteLine(x);

            y1 = Math.Pow(d, 2);
            y = ((5 * (a + b) * (c - d)) / ((1.0 / 2) * c)) + (y1 * ((x1 - x2) / (b - a)));
            Console.WriteLine(y);

            z1 = Math.Pow((Math.Pow(x, 2) - (2 * x)), 3);
            z = ((z1 - (4 * (Math.Pow(x, 4) + 1))) * (1 - b)) / ((5 * a) + (3 * b));
            Console.WriteLine(z);

            r = ((((1.0 / 2) * a) + ((3.0 / 4) * b) - 7.0 / 5) / (3 * c + 1)) + (1 / (a - c));
            Console.WriteLine(r);
        }
    }
}


