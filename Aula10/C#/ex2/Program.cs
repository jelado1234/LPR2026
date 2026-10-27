using System;

namespace Retanguliro
{
    class Funcionario
    {
        public string name = "Jaelson";
        public double salary = 2000.00;
        public double tax = 0.10;
        public double raise = 0;
        public double afterTax = 1800.00;
        public void showFunc()
        {
            Console.WriteLine($"{name} / R${afterTax:F2}");
        }
        public void raiseFunc()
        {
            Console.Write("Porcentagem de aumento (ex: 2 para 2%): ");

            raise = Convert.ToDouble(Console.ReadLine());
            raise = raise / 100;
            salary = salary + (salary * raise);

            taxCalc();
            Console.WriteLine($"Novo salario bruto: R${salary:F2}");
            Console.WriteLine($"Após impostos: R${afterTax:F2}");

        }
        public double taxCalc()
        {
            if (salary > 3001)
            {
                tax = 0.20;
            }
            else if (salary > 2001)
            {
                tax = 0.15;
            }
            else
            {
                tax = 0.10;
            }
            afterTax = salary - (salary * tax);
            return tax;
        }
    }
    class Program
    {
        static void falar(string m) => Console.Write(m);
        static void falarEndl(string m) => Console.WriteLine(m);
        static string ouvir() => Convert.ToString(Console.ReadLine());
        static int ouvirInt() => int.Parse(Console.ReadLine());
        static double ouvir2() => Convert.ToDouble(Console.ReadLine());
        static void Main(string[] args)
        {
            Funcionario x = new Funcionario();

            falar("Insira o nome: ");
            x.name = ouvir();

            falar("Insira o salario: ");
            x.salary = ouvir2();

            x.taxCalc();

            menu(x);
        }
        static void menu(Funcionario x)
        {

            falarEndl("\n 1 para mostrar funcionario \n 2 para aumento \n 3  para trocar funcionario \n 4 para sair");
            int choice = ouvirInt();

            switch (choice)
            {
                case 1:
                    x.showFunc();
                    menu(x);
                    break;

                case 2:
                    x.raiseFunc();
                    menu(x);
                    break;

                case 3:
                    falar("Novo nome: ");
                    x.name = ouvir();

                    falar("Novo salario: ");
                    x.salary = ouvir2();

                    x.taxCalc();
                    menu(x);              // stack overflow /ref
                    break;

                case 4:
                    break;
            }

        }
    }
}