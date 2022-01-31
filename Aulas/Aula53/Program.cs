using System;

namespace Aula53
{
    class Area
    {
        public static float Quad(float bas, float alt){
            if(bas== 0 || alt == 0){
                throw new Exception("Base nem altura podem ser igual a 0"); //Lança minha exceção
            }else{
                return bas*alt;
            }
        }
    }
    
    class program
    {
        static void Main(string[] args)
        {
            float n1, n2, res;
            res=n1=n2=0;
            n1= 0F;
            n2= 5F;
            float area;

            try{
                area= Area.Quad(n1, n2);   
                Console.WriteLine("Area do quad: {0}", area);
            }catch(Exception e){
                Console.WriteLine("ERRO: {0}", e.Message);
            }finally{
                Console.WriteLine("Fim do processo");
            }
        }
    }
}

