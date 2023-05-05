namespace ExoAlgo03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double r;
            double calculAire;
            double calculVolume;


            Console.WriteLine("Bienvenue dans ce programme de calcul d'aire et de volume d'une sphère");

            Console.WriteLine("Veuillez saisir le rayon de la sphère");

            r=int.Parse(Console.ReadLine());



            Console.WriteLine("Le rayon du de la sphère est de " +r);

            calculAire=(4*Math.PI)*Math.Pow(r,2);
            calculVolume = (4  * Math.PI * Math.Pow(r,3))/3;

            Console.WriteLine("l'Aire de la sphère est donc de " + calculAire + " et son volume est de " + calculVolume);
        }
    }
}