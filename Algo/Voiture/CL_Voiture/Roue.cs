using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Voiture
{
    public class Roue
    {
        private string dimensionPneuReglementaire;
        private bool tourne;

        
        public Roue()
        {
            this.dimensionPneuReglementaire = "6.50 R 16";
            this.tourne = false;
        }

        public Roue(string dimensionPneu, bool tourne)
        {
            this.dimensionPneuReglementaire = dimensionPneu;
            this.tourne = tourne;
        }

        public Roue(Roue RouACopier)
        {
            this.dimensionPneuReglementaire = RouACopier.dimensionPneuReglementaire;
            this.tourne = RouACopier.tourne;
        }

        public bool Tourner()
        {
            if (this.tourne)
            {
                return false;
            }
            else
            {
                this.tourne = true;
                return true;
            }
        }

        public bool Stopper()
        {
            if (tourne)
            {
                tourne = false;
                return true;
            }
            else
            {
                return false; ;
            }
        }

    }
}
