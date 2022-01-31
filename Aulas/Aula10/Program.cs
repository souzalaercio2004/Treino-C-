using System;

namespace Aulas
{
    class Program
    {
        enum DiaDaSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
        static void Main(string[] args)
        {
            int ds= (int) DiaDaSemana.Sábado;
            Console.WriteLine((DiaDaSemana)ds +" Possue indice {0}", ds);
        }
    }
}
