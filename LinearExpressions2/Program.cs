using System;
using System.Text;

namespace LinearExpressions2
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double m, m1, m2, n, n1, x, a, b, z1, z2, y, y1, y2;

            Console.Write("Введіть число m=");
            m = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть число n=");
            n = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть число x=");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть число a=");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть число b=");
            b = Convert.ToDouble(Console.ReadLine());

            m1 = Math.Pow(m, 1.0 / 2);
            n1 = Math.Pow(n, 1.0 / 2);
            m2 = Math.Pow(m, 3);

            z1 = ((m - 1) * m1 - (n - 1) * n1) / (Math.Pow((m2*n), 1.0 / 2) + n * m + Math.Pow(m, 2) - m);
            Console.WriteLine(z1);

            z2 = (m1 - n1) / m;
            Console.WriteLine(z2);

            y1 = Math.Abs((Math.Pow(x, 2) + b) / a);
            y2 = Math.Pow(Math.Sin(a - b), 2);

            y = 2.4 * y1 +   ((a - b) * y2) + Math.Pow(10, -2) * (x - b);
            Console.WriteLine(y);


        }
    }
}



