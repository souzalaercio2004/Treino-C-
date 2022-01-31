using System;

namespace Aula22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num= new int[5]{1,2,3,4,5};

            foreach (int valor in num)
            {
                Console.WriteLine("valor: "+valor);
            }
            
        }
    }
}
