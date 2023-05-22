namespace ExoAlgo5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string saisie;
            double km;
            double convertion;
            bool saisieValide = false;

            do
            {
                Console.WriteLine("Veuilez saisir un kilomètrage entre 0.01 et 1 000 000");
                saisie = Console.ReadLine();
                if(saisie != "q") 
                {
                   km = double.Parse(saisie);
                    if(km < 0.01 || km > 1000000)
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
                
                while (km > 0)
                {
                    km = km - 1.609;

                }
            }

        }
    }
}