using System;

namespace Aula47
{
    public class Calc
    {
        public int soma(params int[] n){
            int result=0;
            for (int i=0; i<n.Length; i++){
                result+= n[i];
            }
            return result;
        }
        
        public double soma(params double[] n){
            double result=0;
            for (int i=0; i< n.Length; i++){
                result+= n[i];
            }
            return result;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int res;
            Calc calc= new Calc();
            res= calc.soma(10,5);
            Console.WriteLine("resultado {0}", res);
            Console.WriteLine("resultado {0}", calc.soma(10.8, 18.47, 11, 15.4));
        }
    }
}
