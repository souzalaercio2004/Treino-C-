using System;

namespace Aula08
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, soma;
            string nome;
            Console.Write("Digite seu nome: ");
            nome= Console.ReadLine();

            Console.Write("Digite o primeiro valor: ");
            v1= int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");

            v2= Convert.ToInt32(Console.ReadLine());
            soma= v1+v2;

            Console.WriteLine("\nNome digitado: {0}", nome);
            Console.WriteLine("A soma de {0} + {1} é {2}", v1, v2, soma);
        }
    }
}
