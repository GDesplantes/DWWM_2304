using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Voiture
{
    public class Moteur
    {
        bool enMarche;
        public bool EnMarche { get => enMarche; private set => enMarche = value; }

        public Moteur()
        {
            enMarche = false;
        }
        public Moteur(bool enMarche)
        {

        }

        public Moteur (Moteur MoteurACopier)
        {
            this.enMarche = MoteurACopier.enMarche;
        }


        public bool Demarrer()
        {
             if (enMarche)
                {
                    return false;
                }
             else
                {
                    enMarche = true;
                    return true;
                }
        }

        public bool EntrainerRoues(Roue roue1, Roue roue2)
        {
            bool roue1ATourne = roue1.RoueTourne();
            bool roue2ATourne = roue2.RoueTourne();
            if (roue1ATourne && roue2ATourne)
            {
                return true;
            }
            else
            {
                return false;
            }

            // return roue1ATourne && roue2ATourne;
        }


    }
}
