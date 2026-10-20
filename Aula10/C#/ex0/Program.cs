using System;

namespace Aula10
{
    class Produto
    {
        private string nome = "insira texto";
        private double preco = 0.99;

        public Produto(string n, double p)
        {
            this.nome = n;
            this.preco = p;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Produto hamburge = new Produto("X_ratão", 12.80);
            Produto refri = new Produto("Dr.Perky", 2);
            Produto Mr_Krabs_says_the_nword = new Produto("YourBillSir", 100);

        }
    }
}