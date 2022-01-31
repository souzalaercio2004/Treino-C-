using System;

namespace Aula46
{
    class Galinha
    {
        private string nomeGalinha;
        private int numOvo;

        public Galinha(string nomeGalinha){
            this.nomeGalinha= nomeGalinha;
            numOvo= 0;
        }

        public string getNomeGalinha(){
            return nomeGalinha;
        }

        public int getNumOvo(){
            return numOvo;
        }

        public Ovo botar(){
            numOvo++;
            Ovo.totalOvos++;
           return new Ovo(numOvo, this.nomeGalinha);
        }
    }
    
    class Ovo
    {
        public static int totalOvos=0;
        private int numOvo;
        private string minhaGalinha;
        
        public Ovo(int numOvo, string minhaGalinha){
            this.numOvo= numOvo;
            this.minhaGalinha= minhaGalinha;

            Console.WriteLine("Ovo {0} da galinha {1} criado", numOvo, minhaGalinha);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Galinha g1= new Galinha("Magricela");
            Galinha g2= new Galinha("gorda");
            Galinha g3= new Galinha("Botadeira");

            g1.botar();
            g2.botar();
            g3.botar();
            g1.botar();
            g1.botar();
            g1.botar();
            g2.botar();

            Console.WriteLine("A galinha {0} \t botou ....: {1}", g1.getNomeGalinha(), g1.getNumOvo());
            Console.WriteLine("A galinha {0} \t botou ....: {1}", g2.getNomeGalinha(), g2.getNumOvo());
            Console.WriteLine("A galinha {0} \t botou ....: {1}", g3.getNomeGalinha(), g3.getNumOvo());
            Console.WriteLine("Total de ovos....: {0}", Ovo.totalOvos);



        }
    }
}
