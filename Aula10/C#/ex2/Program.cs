using System;

namespace Retanguliro
{
    class Funcionario
    {
        public string name = "";
        public double salary = 0;
        public string showFunc()
        {
            return $"{name} / {salary}";
        }
        public double raiseFunc()
        {
            if (salary > 3000)
            {
                salary = salary + salary * 0.20;
            } else if (salary > 2000)
            {
                salary = salary + salary * 0.15;
            } else
            {
                salary = salary + salary * 0.10;
            }
        }
    }
    class Program
    {
        
    }