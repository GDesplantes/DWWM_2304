using System;

namespace ExoAlgo3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nb1;
            int nb2;

            Console.WriteLine("Bienvenue dans ce programme d'affichage d'intervalle entre 2 nombres");

            Console.WriteLine("Saisissez le premier nombre");

            nb1=int.Parse(Console.ReadLine());

            Console.WriteLine("Saisissez le second nombre");

            nb2=int.Parse(Console.ReadLine());

            Console.WriteLine("Resultat ");

            if (nb1 < nb2 - 1)
            {
                do
                {
                    nb1++;
                    Console.WriteLine(nb1);







                }

                while (nb1 < nb2 - 1);
            }

            else if (nb2<nb1-1)
            {
                do
                {
                    nb1--;
                    Console.WriteLine(nb1);

                }
                while (nb2 < nb1 - 1);
            }

        }
    }
}