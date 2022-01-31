using System;

namespace Aula20
{
    class Program
    {
        static void Main(string[] args)
        {
            int []num= new int[10];
            int i= num.Length -1;
            while (i> -1)
            {
                Console.WriteLine("Hello World! {0}", i);
                i--;
            }
             Console.WriteLine("Fim do Loop!");
        }
    }
}
