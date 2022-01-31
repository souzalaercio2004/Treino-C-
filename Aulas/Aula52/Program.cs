using System;

namespace Aula52
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, res;
            res=n1=n2=0;
            n1= 10;
            n2= 0;
            try{
                res= n1/n2;
                Console.WriteLine("divisão de {0} por {1} resulta em {2}", n1, n2, res);
            }catch(DivideByZeroException e){
                Console.WriteLine("ERRO: {0}", e.GetType());
            }
        }
    }
}
