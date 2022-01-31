using System;

namespace Aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]vetor1= new int[5];
            int[]vetor2= new int[5];
            int[]vetor3= new int[5];
            int[,]matriz= new int[2,5]{{11,22,35,45,60}, {7,15,49,55,36}};
           
           Random random= new Random();

           for (int i=0; i < vetor1.Length; i++)
           {
               vetor1[i]= random.Next(50);

           }
            
            Console.WriteLine("Elemetos do vetor1:");
            foreach(int valor in vetor1)
            {
                Console.WriteLine(valor);
            }

            Console.WriteLine("Binary Search");
            int procurado= 33;
            int pos= Array.BinarySearch(vetor1, procurado);
            Console.WriteLine("o valor {0} esta na posicao {1}", procurado, pos);
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Copy");
            Array.Copy(vetor1, vetor2, vetor1.Length);

            foreach(int n in vetor2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("CopyTo");
            vetor1.CopyTo(vetor3, 0);
            foreach(int n in vetor3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("GetLongLength");
            long qtdElementosVetor= vetor1.GetLongLength(0);
            Console.WriteLine("Quantidade de elementos {0}", qtdElementosVetor);
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("GetLowerBound");
            int menorIndiceVetor= vetor1.GetLowerBound(0);
            int menorIndiceMatriz_D1= matriz.GetLowerBound(1);
            Console.WriteLine("Menor indice do vetor {0}", menorIndiceVetor);
            Console.WriteLine("Menor indice do Matriz {0}", menorIndiceMatriz_D1);
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("GetUpperBound");
            int maiorIndiceVetor= vetor1.GetLowerBound(0);
            int maiorIndiceMatriz_D1= matriz.GetLowerBound(1);
            Console.WriteLine("Maior indice do vetor {0}",maiorIndiceVetor);
            Console.WriteLine("Maior indice do Matriz {0}", maiorIndiceMatriz_D1);
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("GetValue");
            int valor0= Convert.ToInt32(vetor1.GetValue(3));
            int valor1= Convert.ToInt32(matriz.GetValue(1,3));
            Console.WriteLine("Valor da posicao 3 do vetor1 {0}",valor0);
            Console.WriteLine("Valor da posiao (1,3) da matriz {0}", valor1);
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("IndexOf");
            int indice0= Array.IndexOf(vetor1,3);
            //int indice1= Array.IndexOf(matriz, 33);
            Console.WriteLine("Indice do primeiro valor 3 no vetor1 {0}",indice0);
            //Console.WriteLine("Indice do primeiro valor 33 da matriz", indice1);
            Console.WriteLine("--------------------------------------------");           

            Console.WriteLine("LastIndexOf");   
            indice0= Array.LastIndexOf(vetor1,3);
            //int indice1= Array.LastIndexOf(matriz, 33);
            Console.WriteLine("Indice do primeiro valor 3 no vetor1 {0}",indice0);
            //Console.WriteLine("Indice do primeiro valor 33 da matriz", indice1);
            Console.WriteLine("--------------------------------------------"); 

            Array.Reverse(vetor1);
            foreach (int n in vetor1)
            {
                Console.WriteLine(n);
            }  

            vetor2.SetValue(99,0);
            for (int i=0; i< vetor2.Length; i++)
            {
                vetor2.SetValue(0,i);
            }
           
            Console.WriteLine("vetor2");
            foreach (int n in vetor2)
            {
                Console.WriteLine(n);
            } 
            Array.Sort(vetor1);
            Array.Sort(vetor2);
            Array.Sort(vetor3);
            Array.Reverse(vetor3);

            Console.WriteLine("vetor1");
            foreach (int n in vetor1)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("vetor2");
            foreach (int n in vetor2)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("vetor3");
            foreach (int n in vetor3)
            {
                Console.WriteLine(n);
            }

        }
    }
}
