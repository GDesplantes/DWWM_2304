namespace ExoAlgo4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] nombres = { 8, 16, 32, 64, 128, 256, 512};
            int cherche;
            int index = 0;

            Console.WriteLine("Chercher un nombre dans le tableaux");

            cherche=int.Parse(Console.ReadLine());

          
            while (index < nombres.Length && cherche != nombres[index]);
            {
                index++;
            }

            if (index < nombres.Length)
            {
                Console.WriteLine(nombres[index] + " est present dans le tableau à l'indice " + index);
            }
            else
            {
                Console.WriteLine("Nombre non trouvé");
            }


  
        }
    }
}