using CL_Voiture;

namespace ConsoleAppVoiture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture SchoumiMobile = new Voiture("SchoumiCorps", "235 R 56", false, false);

            bool Demarrage = SchoumiMobile.Demarrer();
            bool avancer = SchoumiMobile.Avancer();

            int a=0;
            

        }
    }
}