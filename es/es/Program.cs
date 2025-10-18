using static System.Console;
namespace es
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Veicolo> veicoli = new List<Veicolo>();

            veicoli.Add(new Auto("Fiat", "Panda"));
            veicoli.Add(new Monopattino(2));
            veicoli.Add(new Drone());
            veicoli.Add(new Elicottero());
            veicoli.Add(new Autobus(1, 30));

            for(int i = 0; i < veicoli.Count; i++)
            {
                veicoli[i].accendi();
               WriteLine(veicoli[i].mostraInfo());

                if(veicoli[i] is Ivolante volante)
                {
                    WriteLine($"veicolo volante trovato in posizione {i}");
                }
                if(veicoli[i] is Icondivisibile condivisibile)
                {
                    if(condivisibile.disponibile)
                    {
                        WriteLine($"trovato veicolo disponibile per la condivisione in posizione {i}");
                    }
                }
            }

        }
    }
}
