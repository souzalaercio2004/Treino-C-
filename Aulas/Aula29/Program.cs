using System;

namespace Aula29
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

        public Jogador(string nome, int energia, bool estaVivo)
        {
            this.nome=nome;
            this.energia= energia;
            this.vivo= estaVivo;
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


            Console.WriteLine("Energia do Jogador {0}: {1}", j1.nome, j1.energia);
            Console.WriteLine("Energia do Jogador {0}: {1}", j2.nome, j2.energia);
            Console.WriteLine("Jogador {0} esta vivo? {1}", j3.nome, j3.vivo);
            Console.WriteLine("O Jogador {0}: tem energia no nivel {1} e esta vivo? {2}", j4.nome, j4.energia, j4.vivo);
        }
    }
}

