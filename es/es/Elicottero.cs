using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    internal class Elicottero: Veicolo, Ivolante
    {
        public int quotamassima {  get; set; } = 0;
        bool acceso { get; set; }
        public override void accendi()
        {
            acceso = true;
        }
        public override void spegni()
        {
            acceso = false;
        }

        public override string mostraInfo()
        {
            string ac;
            if (acceso)
            {
                ac = "acceso";
            }
            else
            {
                ac = "spento";
            }

            return $"Elicottero - Acceso: {ac}, Quota : {quotamassima} piedi";
        }

        public void atterra()
        {
            quotamassima = 0;
        }

        public void decolla()
        {
            quotamassima = 3000;
        }
    }
}
