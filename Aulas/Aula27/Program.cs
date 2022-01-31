using System;

namespace Aula27
{
    class Program
    {
        static void Main(string[] args)
        {
            soma(10,15,20,56);
        }

        static void soma(params int[]n) //Função que recebe zero ou mais argumentos num Array de int
        {
            int res= 0;
            if (n.Length < 1)
            {
                Console.WriteLine("Não existem valores a serem somados");
            }else if (n.Length <2)
            {
                Console.WriteLine("Paramentros insuficientes para soma {0}", n[0]);
            }else 
            {
                for (int i=0; i< n.Length; i++)
                {
                    res +=n[i];
                }
                
                Console.WriteLine("A  soma de {0} valores resulta em {1}", n.Length, res);
            }
        }
    }
}
