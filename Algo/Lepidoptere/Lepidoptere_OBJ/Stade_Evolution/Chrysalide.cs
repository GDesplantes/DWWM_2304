using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere_OBJ.Stade_Evolution
{
    internal class Chrysalide : StadeEvolution
    {
        public Chrysalide() // Constructeur Default
        {

        }
        public override void seDeplacer()
        {
            Console.WriteLine(" Je ne peux pas bouger");
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return new Papillon();
        }
    }
}

