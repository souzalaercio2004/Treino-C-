using System;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1= 10;
            float n2= n1; // Cast implicito
            char c= '#';
            int valorAscII= c; // cast implicito
            float n3= 3.1415f;
            int n4= (int)n3; // type cast
            //short n5= n1; Não é possível converter implicitamente o tipo 'int' em 'short'
            short n5= (short) n1;
            Console.WriteLine("Valor: {0}", n2);
            Console.WriteLine("Cast explicito de char para int: {0}", valorAscII);
            Console.WriteLine("Type cast de float para int: {0}", n4);
             Console.WriteLine("Type cast de int para short: {0}", n5);
        }
    }
}
