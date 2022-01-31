using System;

namespace Aula30
{
    public class Jogador{
        public int energia;
        public bool vivo;
        public string nome;

        public Jogador()
        {
            energia= 100;
            vivo= true;
            nome="";
        }

        public Jogador(string nome)
        {
            energia= 100;
            vivo= true; 
            this.nome= nome;
        }

        public Jogador(string nome, int energia)
        {
            this.nome= nome;
            this.energia= energia;
            this.vivo= true;
        }
        public Jogador(string nome, int energia, bool estaVivo)
        {
            this.nome=nome;
            this.energia= energia;
            this.vivo= estaVivo;
        }

        public void exibir()
        {
            
            Console.WriteLine("O jogador  {0} que está com energia no nível {1} esta vivo? {2}", nome, energia, vivo);
        }

        ~Jogador() //Destrutor
        {
            Console.WriteLine("O jogador {0} foi destruido", nome);
        }

    }
    
    class Aula28
    {
        static void Main(string[] args)
        {
            Jogador j1= new Jogador("Joao");
            Jogador j2= new Jogador("Fred");
            Jogador j3= new Jogador("Zico");
            j2.energia= 95;
            j3.vivo= false;
            j3.energia= 0;

            Jogador j4= new Jogador("Bruno Henrique", 95, true);

            j1.exibir();
            j2.exibir();
            j3.exibir();
            j4.exibir();

            
        }
    }
}
