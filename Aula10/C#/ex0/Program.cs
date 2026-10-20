using System;

namespace Trianguliro
{
    class Triangulo
    {
        public double ladoA = 0;
        public double ladoB = 0;
        public double ladoC = 0;


        public double Area()
        {
            double p = (ladoA + ladoB + ladoC) / 2;
            return Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));
        }
    }
    class Program
    {
        static void falar(string m) => Console.Write(m);
        static void falarEndl(string m) => Console.WriteLine(m);
        static string ouvir() => Convert.ToString(Console.ReadLine());
        static int ouvirInt() => int.Parse(Console.ReadLine());
        static double ouvir2() => double.Parse(Console.ReadLine());
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            falarEndl("Medida dos 3 lados do triangulo X:");
            falarEndl("");

            x.ladoA = ouvir2();
            x.ladoB = ouvir2();
            x.ladoC = ouvir2();

            falarEndl("");
            falarEndl("Medida dos 3 lados do triangulo Y:");
            falarEndl("");

            y.ladoA = ouvir2();
            y.ladoB = ouvir2();
            y.ladoC = ouvir2();

            double areaX = x.Area();
            double areaY = y.Area();

            falarEndl("");
            if (areaX > areaY)
            {
                falarEndl($"O triangulo X de area {areaX} é maior que o triangulo Y de area {areaY}");
            }
            else
            {
                falarEndl($"O triangulo Y de area {areaY} é maior que o triangulo X de area {areaX}");
            }
        }
    }
}