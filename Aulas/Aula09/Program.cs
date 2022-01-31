// Bitwise

using System;

namespace Aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int num1= num <<1;//Bitwise a esquerda em 1 bit = multiplicar por 2
            Console.WriteLine("O deslocamento do numero {0} a esquerda resulta em {1}", num, num1);
            int num2= num >>1; //Bitwise a direira em 1 bit = divividir por 2
            Console.WriteLine("O deslocamento do numero {0} a direita resulta em {1}", num, num2);
        }
    }
}
