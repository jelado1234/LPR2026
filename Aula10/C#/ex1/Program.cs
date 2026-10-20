using System;

namespace Retanguliro
{
    class Retangulo
    {
        public double largura = 0;
        public double altura = 0;
        public double calcArea()
        {
            return largura * altura;
        }
        public double calcPerimetro()
        {
            return 2*largura + 2*altura;
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
            Retangulo x;
            x = new Retangulo();

            falar("Altura e largura do retangulo:");
            falarEndl("");

            x.altura = ouvir2();
            x.largura = ouvir2();

            double area = x.calcArea();
            double perimetro = x.calcPerimetro();

            falarEndl("");
            falarEndl($"Area:      {area}");
            falarEndl($"Perimetro: {perimetro}");
        }
    }
}