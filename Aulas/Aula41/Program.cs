using System;

namespace Aula41
{
    class Carro
    {
        private int velMax;
        
        public Carro()
        {
            this.velMax=120;
        }

        public int vm{ //propriedade Acessors
            get{
                return velMax;
            }
            set{
                if(value <0){
                    this.velMax= 0;
                }else if (value >300){
                    this.velMax= 300;
                }else{
                    this.velMax= value;
                } 

            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1= new Carro();
            c1.vm= 200; // usa o get
            Console.WriteLine("Velocidade: {0}", c1.vm); // usa o set
        }
    }
}