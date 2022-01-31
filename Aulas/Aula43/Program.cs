using System;

namespace Aula43
{
    public interface Veiculo
    {
        void ligar();
        void desligar();
        void info();
    }
    
    public interface Combate
    {
        void disparar();
    }
    
    public class Carro:Veiculo,Combate
    {
        bool ligado;
        private int municao;

        public Carro()
        {
            setMunicao(100);
        }
        
        public int getMunicao()
        {
            return municao;
        }
        
        public void setMunicao(int qtde)
        {
            this.municao= qtde;
        }

        public void ligar(){
            this.ligado= true;
        }

        public void desligar(){
            this.ligado= false;
        }

        public void info(){
            Console.WriteLine("Esta ligado? {0}", ligado);
        }

        public void disparar(){
            municao--;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1= new Carro();
            c1.info();
        } 
    }
}
