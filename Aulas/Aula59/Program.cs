using System;
using System.Collections.Generic;


namespace Aula59
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vs= {"carro", "navio", "avião"};
            Queue<string> veiculos= new Queue<string>(vs);
            veiculos.Enqueue("barco"); //Adiciona no final
            veiculos.Enqueue("metro");

            string v= "avião";
            if (veiculos.Contains(v)){
                Console.WriteLine("Veiculo {0} encontrado", v);
            }else {
                Console.WriteLine("Veiculo {0} não esta na fila", v);
            }
                Console.WriteLine("Removendo o {0} da fila", veiculos.Dequeue());// Retorna o primeiro elemento e remove da queue
            Console.WriteLine("Tamanho da fila: {0}", veiculos.Count);
            Console.WriteLine("Primeiro elemento: {0}", veiculos.Peek()); // Retorna o primeiro elemento sem retirar da fila
            
            foreach(string veic in veiculos){ //Le os elementos sem remover
                Console.WriteLine("Veículo: {0}", veic);
                
            }
            //veiculos.Clear(); //Limpa a queue
            
          S  while (veiculos.Count > 0){
                Console.WriteLine(veiculos.Dequeue());
            }
            Console.WriteLine("Tamanho da fila: {0}", veiculos.Count);
        }
    }
}
