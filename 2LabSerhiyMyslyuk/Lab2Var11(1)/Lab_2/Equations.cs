using System;

namespace Lab_2
{
    public class Equations
    {
        public double a, b, c, d, e, f;
        public double x, y;
        public Equations()
        {
            PrintAll();
        }
        public virtual void Value()
        {
            Console.Write("Введiть значення (a1): ");
            double a = double.Parse(Console.ReadLine());
            this.a = a;
            Console.Write("Введiть значення (b1): ");
            double b = double.Parse(Console.ReadLine());
            this.b = b;
            Console.Write("Введiть значення (c1): ");
            double c = double.Parse(Console.ReadLine());
            this.c = c;
            Console.Write("Введiть значення (a2): ");
            double d = double.Parse(Console.ReadLine());
            this.d = d;
            Console.Write("Введiть значення (b2): ");
            double e = double.Parse(Console.ReadLine());
            this.e = e;
            Console.Write("Введiть значення (c2): ");
            double f = double.Parse(Console.ReadLine());
            this.f = f;

        }
        public void PrintAll()
        {
            Value();

            Console.WriteLine();

            Console.WriteLine("Система рiвнянь:");
            Console.WriteLine("{0}x+{1}y={2}", a, b, c);
            Console.WriteLine("{0}x+{1}y={2}", d, e, f);

            Console.WriteLine();

            Console.WriteLine("Натиснiть будь-яку клавiшу.");
            Console.ReadKey();
            Solution(a, b, c, d, e, f, x, y);
        }

        public static void Solution(double a, double b, double c, double d, double e, double f, double x, double y)
        {
             x = (c * e - b * f) / (a * e - b * d);
             y = (a * f - c * d) / (a * e - b * d);

            Console.WriteLine("\nX = " + x + "; Y = " + y);

            if((a*x+b*y==c)&&(d * x + e * y ==f))
            {
                Console.WriteLine("Точка є розвязком системи рiвнянь.");
            }
            else
            { Console.WriteLine("Точка не є розвязком системи рiвнянь."); }

        }
       
    }
}