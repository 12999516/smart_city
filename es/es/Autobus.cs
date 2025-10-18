using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    internal class Autobus: Veicolo, Icondivisibile
    {
        private int lunghezza;
        public bool disponibile { get; set; } = true;
        public int id { get; set; }

        public Autobus(int id, int lunghezza)
        {
            this.id = id;
            this.lunghezza = lunghezza;
        }

        public override void accendi()
        {
            disponibile = true;
        }
        public override void spegni()
        {
            disponibile = false;
        }

        public override string mostraInfo()
        {
            string ac;

            if (disponibile)
            {
                ac = "disponibile";
            }
            else
            {
                ac = "non disponibile";
            }

            return $"Autobus ID: {id}, Lunghezza: {lunghezza} metri, Disponibilità: {disponibile}";
        }
    }
}
