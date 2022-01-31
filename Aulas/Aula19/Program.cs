using System;

namespace Aula19
{
    class Program
    {
        static void Main(string[] args)
        {
            int []num= new int [10];
            for (int i=0; i <num.Length; i++)
            {
              num[i]= i;
              Console.WriteLine("Valor de num {0}", num[i]);  
            }
            
        }
    }
}
