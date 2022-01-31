using System;

namespace Aula36
{
    //classe base
    class Veiculo 
    {
        public int velAtual;
        private int velMax; // Acesso permitido somente aos membros da classe
        protected bool ligado; //Permite o acesso pelas classes derivadas

        public Veiculo(int velMax)
        {
            velAtual=0;
            this.velMax= velMax;
            ligado= false;
        }

        public int getVelMax()
        {
            return velMax;
        }

        public bool getLigado()
        {
            return ligado;
        }
    }

    class Carro:Veiculo
    {
        public string nome;

        public Carro(string nome, int vm):base(vm)
        {
            this.nome= nome;
            ligado= true;
            
        }
    }


    
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro= new Carro("Bonitão", 120);
            Console.WriteLine("Nome...........: {0}", carro.nome);
            Console.WriteLine("Vel Atual........: {0}", carro.velAtual);
            Console.WriteLine("Vel Max........: {0}", carro.getVelMax());
            Console.WriteLine("Ligado.........: {0}\n", carro.getLigado());
        }
    }
}
