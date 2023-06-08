using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Bouteille
{
    public class Bouteille
    {
        public readonly double capaciteEnL;
        public double quantiteEnL;
        public readonly string nomMarque;
        public string nomLiquide;
        public bool estOuverte;


        public Bouteille(bool _estOuverte, double _capaciteEnL, string _nomMarque, string _nomLiquide)
        {
            this.capaciteEnL = _capaciteEnL;
            this.quantiteEnL = _capaciteEnL;
            this.nomLiquide = _nomLiquide;
            this.nomMarque = _nomMarque;
            this.estOuverte = _estOuverte;

        }

        public Bouteille()
        {
            capaciteEnL = 1.5;
            quantiteEnL = capaciteEnL;
            nomLiquide = "Eau";
            nomMarque = "Evian";
        }


        public bool Ouvrir()
        {
            if (this.estOuverte)
            {
                return false;
            }
            else
            {
                this.estOuverte = true;
                return true;
            }
        }

        public bool Fermer()
        {
            if (this.estOuverte)
            {
                this.estOuverte = false;
                return true;
            }

            else

            {
                return false;
            }
        }

        public bool Remplir()
        {
            if (this.estOuverte)
            {

                if (this.quantiteEnL < this.capaciteEnL)
                {
                    this.quantiteEnL = this.capaciteEnL;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            else
            {
                return false;
            }
        }

        public bool Vider()
        {
            if (this.estOuverte)
            {
                if (this.quantiteEnL > 0)
                {
                    this.quantiteEnL = 0;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public bool RemplirDe(double quantiteAAjoute)
        {
            if (this.estOuverte)
            {
                if (this.quantiteEnL + quantiteAAjoute > capaciteEnL)
                {
                    return false;

                }
                else
                {
                    this.quantiteEnL = this.quantiteEnL + quantiteAAjoute;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public bool ViderDe(double quantiteAVider)
        {
            if (estOuverte)
            {
                if (this.quantiteEnL - quantiteAVider < 0)
                {
                    return false;
                }

                else
                {
                    this.quantiteEnL = quantiteAVider - this.quantiteEnL;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
