using System;

namespace Aula31
{
    static public class Jogador{
        static public int energia;
        static public bool vivo;
        static public string nome;

        static public void iniciar(string n)
        {
            energia= 100;
            vivo= true; 
            nome= n;
        }

        

        static public void exibir()
        {
            
            Console.WriteLine("O jogador  {0} que está com energia no nível {1} esta vivo? {2}", nome, energia, vivo);
        }


    }

    class Inimigo{
        static public bool alerta;
        string nome;

        public Inimigo(string n)
        {
            alerta= false;
            nome= n;
        }

        

        public void info()
        {
            Console.WriteLine("Nome: "+nome);
            Console.WriteLine("Alerta: "+alerta);
            Console.WriteLine("--------------------------------");
        }

    }
    
    class Aula28
    {
        static void Main(string[] args)
        {
            Jogador.iniciar("Bruno Henrique");
            Jogador.exibir();

        
        Inimigo i1= new Inimigo("Doido");
        Inimigo.alerta= true;
        Inimigo i2= new Inimigo("Maluco");
        Inimigo i3= new Inimigo("Zangado");

        i1.info();
        i2.info();
        i3.info();
            
        }
    }
}
