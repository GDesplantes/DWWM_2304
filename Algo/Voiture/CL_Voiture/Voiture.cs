using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Voiture
{
    public class Voiture
    {
        private string marque;
        private Moteur sonMoteur;
        private List<Roue> ses4Roues;

        public Voiture(string marque, Moteur sonMoteur, List<Roue> ses4Roues)
        {
            this.marque = marque;
            this.sonMoteur = sonMoteur;
            this.ses4Roues = ses4Roues;
        }
        public Voiture(string marque, string dimensionPneu, bool tourne, bool enFonctionnement)
        {
            this.marque = marque;
            this.sonMoteur = new Moteur(enFonctionnement);
            this.ses4Roues = new List<Roue>
            { 
                new Roue(dimensionPneu,tourne),
                new Roue(dimensionPneu,tourne),
                new Roue(dimensionPneu,tourne),
                new Roue(dimensionPneu,tourne)
            };
        }

        public bool Demarrer()
        {
            return sonMoteur.Demarrer();
             
        }

        public bool Avancer()
        {
            return sonMoteur.EntrainerRoues(ses4Roues[0], ses4Roues[1]);
        }

        public bool Freiner()
        {
            return sonMoteur.ArreterRoues(ses4Roues[0], ses4Roues[1]);
        }


    }
}
