using System;
using System.Collections.Generic;

namespace Aula58
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> carros= new List<string>();
            string[] carros2= new string[6];
            carros.Add("Golf");
            carros.Add("HRV");
            carros.Add("Monza");
            carros.Add("Picasso");

            foreach( string c in carros){
                Console.WriteLine("Carro: {0}", c);
            }
            
            if (carros.Contains("Golf")){
                Console.WriteLine("Carro encontrado");
            }else{
                Console.WriteLine("Carro não encontrado");
            }
            //carros2.AddRange(carros); //Adiciona todos os elementos da lista carros na lista carros2
            carros.Insert(1, "Strada"); // Insere na posicao 1 da lista carros
            carros.CopyTo(carros2, 1); //Remove todos os elementos da lista carros

            foreach( string c in carros2){
                Console.WriteLine("Carro da lista2: {0}", c);
            }
            string s= "Picasso";
            int pos= carros.IndexOf(s);// Retorna o indice do primeiro elemento s na Lista
            Console.WriteLine("O carro {0} esta na posição {1}", s, pos);
            pos= carros.LastIndexOf("Monza"); //Retorna a posicao do ultimo Monza da lista
            Console.WriteLine("O carro {0} esta na posição {1}", "Monza", pos);
            carros.Insert(5, "Alfa Romeo");
            carros.Sort();
            Console.WriteLine(" \n####Lista de Carros ordenada###");
            foreach( string c in carros){
                Console.WriteLine("{0}", c);
            }
            int tam= carros.Count;
            Console.WriteLine(" \n Quantidade de carros: {0}", tam);
            
        }
    }
}
