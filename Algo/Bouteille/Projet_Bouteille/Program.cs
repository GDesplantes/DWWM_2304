using CL_Bouteille;

namespace Projet_Bouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bouteille bouteilleGuillaume = new Bouteille(true, 2, "Papillon", "JackDaniels");

            Bouteille bouteilleFLOGNEEE = new Bouteille(bouteilleGuillaume);

            bool ouvrir = bouteilleGuillaume.Ouvrir();
            bool fermer = bouteilleGuillaume.Fermer();

            bool remplir = bouteilleGuillaume.Remplir();
            bool videDe = bouteilleGuillaume.ViderDe(1000000000);
            bool vider = bouteilleGuillaume.Vider();
            bool remplirDe = bouteilleGuillaume.RemplirDe(1.5);

            bool ouvrir2 = bouteilleGuillaume.Ouvrir();

            bool vider2 = bouteilleGuillaume.Vider();
            
            bool remplirDe21 = bouteilleGuillaume.RemplirDe(1.5);
            bool viderDe2 = bouteilleGuillaume.ViderDe(2000000);
            bool remplirDe2 = bouteilleGuillaume.RemplirDe(2000000);


            int a=0;
        }
    }
}