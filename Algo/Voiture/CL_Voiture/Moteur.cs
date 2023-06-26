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
            this.enMarche = false;
        }
        public Moteur(bool enMarche)
        {
            this.enMarche = enMarche;
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
                    Console.Write("Le moteur Demarre ");
                    return true;
                }
        }

        public bool Eteindre()
        {
            if (!enMarche)
            {
                return false;
            }
            else
            {
                enMarche= false;
                return true;
            }
        }

        public bool EntrainerRoues(Roue roue1, Roue roue2)
        {
            bool roue1ATourne = roue1.Tourner();
            bool roue2ATourne = roue2.Tourner();
            if (roue1ATourne && roue2ATourne)
            {
                Console.WriteLine("GOTTA GO FAST!");
                return true;
            }
            else
            {
                return false;
            }

            // return roue1ATourne && roue2ATourne;
        }

        public bool ArreterRoues(Roue roue1, Roue roue2)
        {
            bool roue1AStop = roue1.Stopper();
            bool roue2AStop = roue2.Stopper();
            if (roue1AStop && roue2AStop)
            {
                return true;
            }
            else
            {
                return false;
            }
            // return roue1AStop && roue2AStop;
        }


    }
}
