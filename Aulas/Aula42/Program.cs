using System;

namespace Aula42
{
    
    class Carro
    {
        private int[] velMax= new int[5]{80, 120, 150, 30, 180};
        
        public Carro()
        {
        
        }

        //indexador
        public int this[int i]{ //propriedade Acessors
            get{
                return velMax[i];
            }
            set{
                if(value <0){
                    this.velMax[i]= 0;
                }else if (value >300){
                    this.velMax[i]= 300;
                }else{
                    this.velMax[i]= value;
                } 

            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1= new Carro();

            //Utilizando o objeto como array. Isso é possivel pois implementei um indexador
            c1[4]= 200; // usa o get
            Console.WriteLine("Velocidade: {0}", c1[4]); // usa o set
        }
    }
}
