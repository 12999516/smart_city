using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    internal class Auto:Veicolo
    {
        private string marca;
        private string modello;
        bool accesa;
        public Auto(string marca, string modello)
        {
            this.marca = marca;
            this.modello = modello;
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
                ac = "accesa";
            }
            else
            {
                ac = "spenta";
            }
            return $"marca: {marca}, modello: {modello}, Stato: {ac}";
        }

    }
}
