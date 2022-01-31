using System;

namespace Aula50
{
    delegate int Op(params int[]n);
    
    class Mat
    {
        public static int soma(params int[] n){
            int res=0;
            for (int i= 0; i< n.Length; i++){
                res += n[i];
            }
            return res;
        }

        public static int mult(params int[] n){
            int res=n[0];
            for (int i= 1; i< n.Length; i++){
                res *= n[i];
            }
            return res;
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Op d1= new Op(Mat.soma);
            int res= d1(1,2,3,435,6,7,8,9,10);
            Console.WriteLine("Resultado {0}", res);
            d1= new Op(Mat.mult);
            res= d1(5,4,3,2,1);
            Console.WriteLine("Resultado {0}", res);
        }
    }
}
