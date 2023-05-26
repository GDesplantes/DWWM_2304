namespace ExoAlgo5._2._1
{
    internal class Program
    {
        static double conversionKmMi(double kilometre)
        {
            double mi = kilometre / 1.609;
            return mi;
        }

        static void Main(string[] args)
        {

            string saisie;
            double km=0;
            double convertion;
            bool saisieValide = false;


            do
            {
                Console.WriteLine("Veuilez saisir un kilomètrage entre 0.01 et 1 000 000");
                saisie = Console.ReadLine();
                if(saisie != "q") 
                {
                   km = double.Parse(saisie);
                    if(km >= 0.01 && km <= 1000000)
                    {
                        saisieValide=true;
                    }
                }
            }
            while (!saisieValide && saisie!="q");

            if (saisie == "q")
            {
                Console.WriteLine(" Fin de programme");
            }
            else
            {
              
                Console.WriteLine("Résultat = " + conversionKmMi(km) + " miles");
                
            }

        }
    }
}