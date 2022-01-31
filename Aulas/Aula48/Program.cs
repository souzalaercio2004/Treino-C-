using System;

namespace Aula48
{
    class Calc{
        public double fat(double n){
            double res;
            if(n<=1){
                res=1;
            }else{
                res= n*fat(n-1);
            }
            return res;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc= new Calc();
            double n= 100;
            Console.WriteLine("Fatorial de {0}= {1}", n, calc.fat(n));
            Console.WriteLine("Valor Maximo= {0}", double.MaxValue);
        }

        
    }
}
