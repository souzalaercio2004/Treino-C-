using System;
using System.Collections.Generic;

namespace Aula56
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> transp= new LinkedList<string>();

            transp.AddFirst("Carro");
            transp.AddFirst("Navio");
            transp.AddFirst("Avião");
            transp.AddFirst("Motocicleta"); //Adicionar no Inicio

            transp.AddLast("Bicicleta"); //Adicionar no final
            
            LinkedListNode<string> no= transp.FindLast("Navio");
            transp.AddAfter(no, "Patinete"); // Adidionar depois
            no= transp.FindLast("Carro");
            transp.AddBefore(no, "Patins"); //Adicionar antes

            
            foreach(string t in transp){
                Console.WriteLine("Transporte: {0}", t);
            }

            if (transp.Find("Carro") == null){
                Console.WriteLine("Não encontrado");
            }else{
                Console.WriteLine("Elemento encontrado");
            }

        }
    }
}
