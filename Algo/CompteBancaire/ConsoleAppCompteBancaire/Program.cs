using CL_CompteBancaire;

namespace ConsoleAppCompteBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire compteSchoumi = new CompteBancaire();
            CompteBancaire compteKay = new CompteBancaire( -15 , "Kay", 58123541, 5000);

            string detailcompte = compteSchoumi.ToString();

            bool moula = compteKay.SoldeSuperieur(compteSchoumi);


            
            
            int a = 0;
        }
    }
}