using System;

namespace Aula24
{
    class Program
    {
        static void Main(string[] args)
        {
            cfb();
            int resultado= soma();
            
            Console.WriteLine("resuta em {0}", resultado);
            
            
        }

        static void cfb()
        {
            Console.WriteLine("CFB - Cursos");
            Console.WriteLine("Curso de C#");
            Console.WriteLine("www.youtube.com/cfbCursos");
        }

        static int soma()
        {
            int n1, n2, res;
            Console.WriteLine("Digite o primeiro inteiro: ");
            n1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo inteiro: ");
            n2= Convert.ToInt32(Console.ReadLine());
            Console.Write("A soma de {0} com {1} ", n1, n2);
            res= n1+n2;
            return(res);
            
        }

    }
}
