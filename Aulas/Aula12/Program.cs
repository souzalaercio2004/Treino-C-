using System;

namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont,n1,n2,n3,n4;
            cont=n1=n2=n3=n4=0;

            string resultado= "Reprovado";
            Console.Write("Digite a nota n{0} : ", ++cont);
            n1= int.Parse(Console.ReadLine());

            Console.Write("Digite a nota n{0} : ", ++cont);
            n2= int.Parse(Console.ReadLine());

            Console.Write("Digite a nota n{0} : ", ++cont);
            n3= int.Parse(Console.ReadLine());

            Console.Write("Digite a nota n{0} : ", ++cont);
            n4= int.Parse(Console.ReadLine());

            int nota= n1+n2+n3+n4;


            if (nota > 70) resultado= "Aprovado";
            Console.WriteLine("Nota= {0} - Resultado: {1}", nota, resultado);
        }
    }
}
