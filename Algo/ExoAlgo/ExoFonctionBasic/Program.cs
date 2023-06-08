using System.ComponentModel;

namespace ExoFonctionBasic
{
    internal class Program
    {
        static double Addition(double nombre1, double nombre2)
        {

            nombre1 += nombre2;
            return nombre1;
        }
        
        static void Main(string[] args)
        {

            double r = Addition(2.25, 2.5215);
            Console.WriteLine(r);
        }
    }
}