namespace ExoAlgo3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float argentRestant;
            int nbMagasins = 0;

           
         
            Console.WriteLine("Saisissez l'argent de barnabé");

            argentRestant = float.Parse(Console.ReadLine());

            while (argentRestant < 1)
            {
                Console.WriteLine("Saisissez l'argent de barnabé");

                argentRestant = float.Parse(Console.ReadLine());
            }

            if(argentRestant>1 && argentRestant < 2)
            {
                Console.WriteLine("Barnabé n'a pas asser d'argent pour faire les magasins");
            }

         
           
            while (argentRestant >= argentRestant/2 + 1 )
            {
                argentRestant = argentRestant / 2 - 1; ;
                nbMagasins++;
            }


            Console.WriteLine("Barnabé n'a plus que " + argentRestant + " euros, il a put cependant aller dans " + nbMagasins + " magasins");
        }
    }
}