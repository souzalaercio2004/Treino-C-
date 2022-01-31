using System;

namespace Aula25
{
    class Program
    {
        static void Main(string[] args)
        {
            cfb();
            int resultado= soma();
            
            Console.WriteLine("resuta em {0}", resultado);
            dobrar(ref resultado); // Chamada por referencia
            
            Console.WriteLine("O resutado dobrado é {0} dobrar altera o resultado pois é chamada por referencia", resultado);
            
            dobrar2(resultado);
            Console.WriteLine("O resutado dobrado é {0} dobrar2 não altera o resultado. Chamada por valor", resultado);
            
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

        static void dobrar(ref int valor){ // Passagem de parametro por referencia
            valor*= 2;
        }
        static void dobrar2(int valor){ // Passagem de parametro por valor
            valor*= 2;
        }


    }
}
