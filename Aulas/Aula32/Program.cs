using System;

namespace Aula32
{

    class Calculos
    {
        int v1;
        int v2;

        public Calculos(int v1, int v2)
        {
            this.v1= v1;
            this.v2= v2;
        }

        public int somar()
        {
            
            return v1+v2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculos c1= new Calculos(10,2);
            Console.WriteLine(c1.somar());
        }
    }
}
