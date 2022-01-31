using System;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            int res= (10 + 15)*2;
            bool resultado= res > 100;
            Console.WriteLine("resultado: "+resultado);
            res+=10;
            Console.WriteLine("resultado: "+res);
        }
    }
}
