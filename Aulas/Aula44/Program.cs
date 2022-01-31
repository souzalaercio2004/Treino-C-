using System;

namespace Aula44
{
    struct Carro 
    {
        public string modelo;
        public string marca;
        public string cor;

        public Carro(string modelo, string marca, string cor)
        {
            this.modelo= modelo;
            this.marca= marca;
            this.cor= cor;
        }

        public void info()
        {
            Console.WriteLine("Marca....: {0}", this.marca);
            Console.WriteLine("Modelo...: {0}", this.modelo);
            Console.WriteLine("Cor......: {0}", this.cor);
        }

    }

    class Program
    {
       
        static void Main(string[] args)
        {
            Carro c1= new Carro("Gol", "VW", "Azul");
            c1.info();
        }
    }
}
