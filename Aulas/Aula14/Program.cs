using System;

namespace Aula14
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont,n1,n2,n3,n4;
            cont=n1=n2=n3=n4=0;

            
            Console.Write("Digite a nota n{0} : ", ++cont);
            n1= int.Parse(Console.ReadLine());

            Console.Write("Digite a nota n{0} : ", ++cont);
            n2= int.Parse(Console.ReadLine());

            Console.Write("Digite a nota n{0} : ", ++cont);
            n3= int.Parse(Console.ReadLine());

            Console.Write("Digite a nota n{0} : ", ++cont);
            n4= int.Parse(Console.ReadLine());

            int resultado= n1+n2+n3+n4;
            string res="";
            if (resultado < 40){
                res="Reprovado";
            }else if (resultado < 62)
            {
                res= "Recuperação";

            } else {
                if( resultado >= 90){
                     res= "Aprovado com louvor";
                }else res= "Aprovado";
            }

            Console.WriteLine("Resultado: "+res+" - Nota: "+resultado);
            
        }
    }
}
