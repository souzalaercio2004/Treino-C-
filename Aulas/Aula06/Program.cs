using System;

namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorCompra= 5.50;
            double valorVenda;
            double lucro= 0.1;
            
            string produto= "Pastel";

            valorVenda= valorCompra+(valorCompra*lucro);

            
            Console.WriteLine("Prezado Aluno: {0}\n\n Nesta aula aprenderemos a: {1}\n", "Luiz Fernando" ,"programar em C#");
            Console.WriteLine("Produto.......: {0,15:c}", produto);
            Console.WriteLine("Val. Compra...: {0,15:c}", valorCompra);
            Console.WriteLine("Lucro.........: {0,16:p}", lucro);
            Console.WriteLine("Val. Venda....: {0,15:c}", valorVenda);
        }
    }
}
