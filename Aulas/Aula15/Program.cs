using System;

namespace Aula15
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo=0;
            char escolha= ' ';

            Console.Clear();
            Console.WriteLine("Belo Horizonte-MG a Vitória-ES");
            Console.WriteLine("Escolha o meio de Transporte - (a) - Avião - (t) - Trem (o) - Onibus");
            escolha= char.Parse(Console.ReadLine());
            switch(escolha)
            {
                case 'a':
                case 'A':
                    tempo= 50;
                    break;
                case 't':
                case 'T':
                    tempo= 480;
                    break;
                case 'o':
                case 'O':
                    tempo= 660;
                    break;
                default:
                {
                    tempo= -1;
                    break;
                }
            }

            if (tempo < 0){
                Console.WriteLine("Transporte indisponível");
            }else{
                Console.WriteLine("Para o transporte escolhido o tempo de viagem é "+ tempo + " minutos");
            }

            
            
        }
    }
}
