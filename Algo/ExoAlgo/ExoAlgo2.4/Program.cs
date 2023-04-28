namespace ExoAlgo2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre1;
            int nombre2;
            int nombre3;

            Console.WriteLine("Bienvenue dans ce programme d'affichage de nombre dans un ordre décroissant");

            Console.WriteLine("Veuillez saisir la valeur du nombre1");

            nombre1 =int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir la valeur du nombre2");

            nombre2 =int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir la valeur du nombre3");

            nombre3 =int.Parse(Console.ReadLine());

            if (nombre1<=nombre2 && nombre2<= nombre3)
            {
                Console.WriteLine("l'Ordre décroissant des nombres est de " + nombre3 + "-" + nombre2 + "-" +nombre1);
            }
            else if (nombre1<=nombre3 && nombre3<= nombre2)
            {
                Console.WriteLine("l'Ordre décroissant des nombres est de " + nombre2 + "-" + nombre3 + "-" +nombre1);

            }
            else
            {

            }
            if (nombre2 >= nombre1 && nombre2<= nombre3)
            {
                Console.WriteLine("l'Ordre décroissant des nombres est de " + nombre3 + "-" + nombre2 + "-" + nombre1);
            }
            else if (nombre2 <= nombre3 && nombre3<= nombre1)
            {
                Console.WriteLine("l'Ordre décroissant des nombres est de " + nombre1 + "-" + nombre3 + "-" + nombre2);
            }

            else
            {

            }
                if(nombre2 >= nombre1 && nombre1>= nombre3)
            {
                Console.WriteLine("l'Ordre décroissant des nombres est de " + nombre2 + "-" + nombre1 + "-" + nombre3);
            }
                else if (nombre1 >= nombre2 && nombre2 >= nombre3)
            {
                Console.WriteLine("l'Ordre décroissant des nombres est de " + nombre1 + "-" + nombre2 + "-" + nombre3);
            }
        }
    }
}