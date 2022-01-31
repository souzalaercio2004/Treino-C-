using System;

namespace Aula21
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha= "123";
            string senhaUser;
            int tentativas=0;
            do{
                Console.Clear();
                Console.WriteLine("Senha: ");
                senhaUser= Console.ReadLine();
                tentativas++;
            }while(senhaUser!= senha);
            
            Console.Clear();
            Console.WriteLine("Senha Correta. Tentativas {0}", tentativas);

        }
    }
}
