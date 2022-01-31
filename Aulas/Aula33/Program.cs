using System;

namespace Aula33
{
    class Jogador
    {
        private int energia;
        private string nome;

        public Jogador(string nome)
        {
            energia= 100;
            this.nome= nome;
        }

        public int getEnergia()
        {
            return energia;
        }
         
        public string getNome()
        {
            return nome;
        }

        public void setEnergia(int energia)
        {
            if (energia < 0)
            {
                this.energia += energia;
            }else if (energia >100)
            {
                this.energia=0;
            }else this.energia-= energia;
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Jogador j1= new Jogador("Vinicius");
            j1.setEnergia(30);
            Console.WriteLine(j1.getNome());
            Console.WriteLine(j1.getEnergia());
        }
    }
}
