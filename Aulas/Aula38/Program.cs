using System;

namespace Aula38
{
    class Base
    {
        public Base(){
            Console.WriteLine("Construtor da classe base");
        }

        virtual public void info(){}

    }

    class Derivada1:Base
    {
        public Derivada1(){
            Console.WriteLine("Construtor da classe derivada1");
        }

        override public void info()
        {
            Console.WriteLine("Derivada1");
        }
    }

    class Derivada2:Derivada1
    {
        public Derivada2(){
            Console.WriteLine("Construtor da classe derivada2");
        }

        override public void info()
        {
            Console.WriteLine("Derivada2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Base Ref; //Referencia para a classe Base
            Derivada1 derivada1= new Derivada1();
            Derivada2 derivada2= new Derivada2();
            Ref= derivada1;
            Ref.info();

            Ref= derivada2;
            Ref.info();
        }
    }
}

