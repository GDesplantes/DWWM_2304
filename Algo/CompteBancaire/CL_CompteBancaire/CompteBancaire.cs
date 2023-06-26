using System.Linq.Expressions;

namespace CL_CompteBancaire
{
    public class CompteBancaire
    {
        private double decouvertAutorise;
        private string nom;
        private uint numeroCompte;
        private double soldeActuel;

        public double SoldeActuel { get => soldeActuel; private set => soldeActuel = value; }

        public CompteBancaire()
        {
            this.decouvertAutorise = 0;
            this.nom = "Desp Guill";
            this.numeroCompte = 85;
            this.soldeActuel = 125;
        }

        public CompteBancaire(int _decouvertAutorise, string _nom, uint _numeroCompte, double soldeActuel)
        {
            this.decouvertAutorise = _decouvertAutorise;
            this.nom = _nom;
            this.numeroCompte = _numeroCompte;
            this.soldeActuel = soldeActuel;
        }

        public CompteBancaire (CompteBancaire CompteBancaireSecondaire)
        {
            this.decouvertAutorise = CompteBancaireSecondaire.decouvertAutorise;
            this.nom = CompteBancaireSecondaire.nom;
            this.numeroCompte = CompteBancaireSecondaire.numeroCompte;
            this.soldeActuel = CompteBancaireSecondaire.soldeActuel;
        }


        public void Crediter( double montant)
        {
            this.soldeActuel += montant;
        }
         

        public bool Debite( double montant)
        {
            
            if (this.soldeActuel - montant < this.decouvertAutorise)
            {
                
                return false;
            }
            else
            {
                
                this.soldeActuel -= montant;
                return true;
            }
        }

        public bool SoldeSuperieur(CompteBancaire compteACompare)
        {
            if (this.soldeActuel > compteACompare.soldeActuel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferer(int montant, CompteBancaire compteDestinataire)
        {
            if (this.soldeActuel-montant > decouvertAutorise)
            {
                this.soldeActuel -= montant;
                compteDestinataire.soldeActuel+=montant;
                return true;
            }
            else
            {
                return false;
            }

        }

        public string ToString()
        {
            string maChaine = "Nom du Compte = " + this.nom +
                " Numero de compte = " + this.numeroCompte +
                " Solde actuel = " + this.soldeActuel +
                " Decouvert autorisé = " + this.decouvertAutorise;

            return maChaine;
        }




    }
}