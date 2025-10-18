using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    internal class Drone: Veicolo, Ivolante
    {
        bool accesa;
        public int quotamassima { get; set; } = 0;
        public void decolla()
        {
            quotamassima = 500;
        }

        public void atterra()
        {
            quotamassima = 0;
        }

        public override void accendi()
        {
            accesa = true;
        }
        public override void spegni()
        {
            accesa = false;
        }

        public override string mostraInfo()
        {
            string ac;
            if (accesa)
            {
                ac = "acceso";
            }
            else
            {
                ac = "spento";
            }
            return $"Drone - Acceso: {ac}, Quota : {quotamassima} piedi";
        }
    }
}
