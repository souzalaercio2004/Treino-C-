using System;

namespace Aula26
{
    class Program
    {
        static void Main(string[] args)
        {
            int divid= 1024;
            int divis= 120;
            int resto; 
            int res= divisao(divid, divis, out resto);
            Console.WriteLine("Resultado da divisão de {0} por {1} com resto {2} ", divid, divis, resto);
        }

        static int divisao(int dividendo, int divisor, out int resto)// resto é um argumento de saida, assim temos duas saidas
        {
            int quociente;
            quociente= dividendo / divisor;
            resto= dividendo % divisor;
            return quociente;
        }
    }
}
