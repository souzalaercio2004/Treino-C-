using System;

namespace Aula45
{

    struct Carro 
    {
        public string modelo;
        public string marca;
        public string cor;

       

        public void info()
        {
            Console.WriteLine("Marca....: {0}", this.marca);
            Console.WriteLine("Modelo...: {0}", this.modelo);
            Console.WriteLine("Cor......: {0}", this.cor);
            Console.WriteLine("--------------------------------");
        }

    }

    class Program
    {
       
        static void Main(string[] args)
        {
            Carro[] carros= new Carro[5];
            carros[0].marca= "Ford";
            carros[0].modelo= "Escort";
            carros[0].cor= "Amarelo";

            carros[1].marca= "Ford";
            carros[1].modelo= "XR3";
            carros[1].cor= "Vermelho";

            carros[2].marca= "Fiat";
            carros[2].modelo= "Strada";
            carros[2].cor= "Azul";

            carros[3].marca= "Honda";
            carros[3].modelo= "Civic";
            carros[3].cor= "Prata";

            carros[4].marca= "JEEP";
            carros[4].modelo= "Renegade";
            carros[4].cor= "Dourado";

            for (int i=0; i< carros.Length; i++)
            {
              carros[i].info();
            }

        }
    }
}
