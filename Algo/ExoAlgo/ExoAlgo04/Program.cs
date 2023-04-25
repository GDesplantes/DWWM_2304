namespace ExoAlgo04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rayon;
            float angle;
            float calculAireCirculaire;

            Console.WriteLine("Bienvenue dans le programme de calcul de la surface d'un secteur circulaire");
            
            Console.WriteLine("Veuillez saisir la valeur du rayon");

            rayon=float.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir la valeur de l'angle");

            angle=float.Parse(Console.ReadLine());

            calculAireCirculaire = (float)(Math.PI * Math.Pow(rayon, 2) * angle / 360);

            Console.WriteLine("l'Aire circulaire est de " + calculAireCirculaire);


        }
    }
}