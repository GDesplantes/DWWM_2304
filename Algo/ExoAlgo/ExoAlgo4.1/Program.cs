namespace ExoAlgo4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nombres = { 8, 16, 32, 64, 128, 256, 512};
            int cherche;
            int i = 0;

            Console.WriteLine("Chercher un nombre dans le tableaux");

            cherche=int.Parse(Console.ReadLine());

            do
            {
                i++;
            }
            while (i < nombres.Length);


            /*for (int i = 0; i < nombres.Length; i++)
            {
                int resulat = nombres[i];
                if (resulat == cherche)
                {
                    Console.WriteLine(cherche + " est présents dans le tableaux");
                }
                else
                {
                    Console.WriteLine(cherche + "");
                }
            }*/
            


        }
    }
}