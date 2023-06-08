using CL_Bouteille;

namespace Bouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bouteille bouteilleGuillaume = new Bouteille(true, 2, "Papillon", "JackDaniels");

            bool ouvrir = bouteilleGuillaume.Ouvrir();
            bool fermer = bouteilleGuillaume.Fermer();

            bool vider = bouteilleGuillaume.Vider();
            bool remplirDe = bouteilleGuillaume.RemplirDe(1.5);

            bool ouvrir2 = bouteilleGuillaume.Ouvrir();

            bool vider2 = bouteilleGuillaume.Vider();
            bool remplirDe21 = bouteilleGuillaume.RemplirDe(1.5);



            int a;

        }
    }
}