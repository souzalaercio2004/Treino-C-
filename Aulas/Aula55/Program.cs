using System;
using System.Collections.Generic;

//Coleções - Dictionary - dado formado por chave e valor

namespace Aula55
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary <int, string> veiculos= new Dictionary <int, string>();
            veiculos.Add(10, "Carro");
            veiculos.Add(5, "Avião");
            veiculos.Add(0, "Navio");
            veiculos.Add(20, "Moto");
            veiculos.Add(15, "Patinete");
            Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);
            int chave= 20;

            veiculos.Remove(chave);
            if(veiculos.ContainsKey(chave)){
                Console.WriteLine("A chave: {0} esta na coleção", chave);
            }else {
                Console.WriteLine("A chave: {0} não esta na coleção", chave);
            }
            veiculos[15]= "Bicicleta";
            string valor= "Bicicleta";
            if(veiculos.ContainsValue(valor)){
                Console.WriteLine("O valor: {0} esta na coleção", valor);
            }else {
                Console.WriteLine("O valor: {0} não esta na coleção", valor);
            }
            
            foreach(KeyValuePair <int, string> v in veiculos){
                Console.WriteLine("Chave: {0}\t valor: {1}", v.Key, v.Value);
            }
            Dictionary<int, string>.ValueCollection valores= veiculos.Values;
            foreach(string v in valores){
                Console.WriteLine(v);
            }
            Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);
            veiculos.Clear(); //Limpa o Dictionary

            
        }
    }
}
