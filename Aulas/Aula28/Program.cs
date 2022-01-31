using System;

namespace Aula28
{
    public class Jogador{
        public int energia= 100;
        public bool vivo= true;

    }
    
    class Aula28
    {
        static void Main(string[] args)
        {
            Jogador j1= new Jogador();
            Jogador j2= new Jogador();
            Jogador j3= new Jogador();
            j2.energia= 95;
            j3.vivo= false;
            j3.energia= 0;


            Console.WriteLine("Energia do Jogador 1: {0}", j1.energia);
            Console.WriteLine("Energia do Jogador 2: {0}", j2.energia);
            Console.WriteLine("Jogador 3 esta vivo? {0}", j3.vivo);

        }
    }
}
