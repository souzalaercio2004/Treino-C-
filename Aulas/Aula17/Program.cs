using System;

namespace Aula17
{
    class Program
    {
        static void Main(string[] args)
        {
            int []num= new int[5]{10,15,20,35,40}; 
            /*
            num[0]= 10;
            num[1]= 15;
            num[2]= 25;
            num[3]= 40;
            num[4]= 65;
            */
            Console.WriteLine("Numero Escolhido: "+num[3]);

            string [] nome={"Antonia", "Marcele", "Francisco", "Regina"};
            Console.WriteLine("Encontramos {0} na posicao 4: ", nome[3]);
        }
    }
}
