using System;

namespace Aula49
{
    class Mat{
        public static double pi= 3.14;

        public static int dobro(int n){
            return 2*n;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
           double vPi= Mat.pi;
           int num= 10;
           
           Console.WriteLine("Dobro: {0}",Mat.dobro(num));
           Console.WriteLine("pi= {0}",Mat.pi);

        }
    }
}
