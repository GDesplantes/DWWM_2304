using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Bouteille
{
    public class Bouteille
    {
        private readonly double capaciteEnL;
        private double quantiteEnL;
        private readonly string nomMarque;
        private string nomLiquide;
        private bool estOuverte;

        public bool Ouverte { get => estOuverte; }


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
            estOuverte=true;
            capaciteEnL = 1.5;
            quantiteEnL = capaciteEnL;
            nomLiquide = "Eau";
            nomMarque = "Evian";
        }
        public Bouteille(Bouteille bouteilleACopier)
        {
            this.estOuverte = bouteilleACopier.estOuverte;
            this.quantiteEnL = bouteilleACopier.capaciteEnL;
            this.capaciteEnL = bouteilleACopier.capaciteEnL;
            this.nomLiquide = bouteilleACopier.nomLiquide;
            this.nomMarque = bouteilleACopier.nomMarque;
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
                    this.quantiteEnL += quantiteAAjoute;
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
                    this.quantiteEnL -= quantiteAVider;
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
