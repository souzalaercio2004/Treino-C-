using System;

namespace Aula51
{
    class Program
    {
        static void Main(string[] args)
        {
            int res= 0;
            
            if (args.Length >0) {
                for (int i=0; i<args.Length; i++){
                    Console.WriteLine("Argumento {0} - {1}", i, args[i]);
                    res+= Int32.Parse(args[i]);
                }
                Console.WriteLine("A soma é : {0}", res);
            }else Console.WriteLine("Não foram passados argumentos");
        }
    }
}
