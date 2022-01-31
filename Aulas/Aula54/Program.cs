using System;

namespace Calc1
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
}

namespace Calc2
{
    class Area
    {
        public static int Quad(int bas, int alt){
            if(bas== 0 || alt == 0){
                throw new Exception("Base nem altura podem ser igual a 0"); //Lança minha exceção
            }else{
                return bas*alt;
            }
        }
    }
}

namespace Aula54
{    
    class program
    {
        static void Main(string[] args)
        {
       
            float area;

            try{
                area= Calc1.Area.Quad(3.25F, 5F);   
                Console.WriteLine("Area do quad: {0}", area);
            }catch(Exception e){
                Console.WriteLine("ERRO: {0}", e.Message);
            }finally{
                Console.WriteLine("Fim do processo");
            }
        }
    }
}


