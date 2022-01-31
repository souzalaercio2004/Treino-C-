using System;

namespace Aula35
{
    class Veiculo //Classe Base
    {
        private int rodas;
        public int velMax;
        private bool ligado;

        public Veiculo(int rodas)
        {
            this.rodas= rodas;
        }
        
        public void ligar()
        {
            ligado= true;
        }

        public void desligar()
        {
            ligado= false;
        }

        public string getLigado()
        {
            return(ligado?"Sim":"Não");   // Operador ternario      
                       
        }

        public int getRodas()
        {
            return rodas;
        }

        public void setRodas(int rodas)
        {
            if (rodas <0)
            {
                this.rodas=0;
            } else if (rodas >40)
            {
                this.rodas= 40;
            }else this.rodas= rodas;
        }

    }

    class Carro:Veiculo // Classe Derivada
    {
        public string nome;
        public string cor;

        public Carro(string nome, string cor): base(4) //chamo o construtor da classe base
        {
            desligar();
            //rodas= 4;
            velMax= 120;
            this.nome= nome;
            this.cor= cor;
        }
    }

    class CarroCombate:Carro // cadeia de herança: veiculo e classe base de carro
    {
        public int municao;

        public CarroCombate():base("Carro Combate", "Verde")
        {
            municao= 100;
            setRodas(6);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1= new Carro("Rapidão", "Vermelho");
            c1.ligar();
            Console.WriteLine("Nome........: {0}", c1.nome);
            Console.WriteLine("Cor.........: {0}", c1.cor);
            Console.WriteLine("Rodas.......: {0}", c1.getRodas());
            Console.WriteLine("Vel.Max.....: {0}", c1.velMax);
            Console.WriteLine("Ligado......: {0}", c1.getLigado());
            Console.WriteLine("-----------------------------------------");

            CarroCombate cc1= new CarroCombate();
            c1.ligar();
            Console.WriteLine("Nome........: {0}", cc1.nome);
            Console.WriteLine("Cor.........: {0}", cc1.cor);
            Console.WriteLine("Rodas.......: {0}", cc1.getRodas());
            Console.WriteLine("Vel.Max.....: {0}", cc1.velMax);
            Console.WriteLine("Ligado......: {0}", cc1.getLigado());
            Console.WriteLine("Munição.....: {0}", cc1.municao);
        }
    }
}
