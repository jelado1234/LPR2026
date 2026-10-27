using System;

namespace Retanguliro
{
    class DS
    {
        public int id;
        public string name;
        public double[] tests = {2.5, 2.5};
        public double gradedW = 2;
        public double avgGrade()
        {
            avg = (gradedW + tests[0] + tests[1]) / 3;
            return avg;
        }
        public void finalsGrade()
        {
            finalAvg = 4.2;
            avgGrade();
            if (avg < finalAvg)
            {
                double need = 4.2 - (avg * 3);
                Console.Write($"Voce precisa de {need} pontos na final para passar.");
            } else
            {
                Console.Write("Aprovado!");
            }
        }
    }
    class Program
    {
        static void falar(string m) => Console.Write(m);
        static void falarEndl(string m) => Console.WriteLine(m);
        static string ouvir() => Convert.ToString(Console.ReadLine());
        static int ouvirInt() => int.Parse(Console.ReadLine());
        static double ouvir2() => Convert.ToDouble(Console.ReadLine());
        static void Main()
        {
            
        }
    }
}