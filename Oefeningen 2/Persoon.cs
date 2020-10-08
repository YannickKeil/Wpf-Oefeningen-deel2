using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_2
{
    public class Persoon
    {
       
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Afbeelding { get; set; }

        public Persoon(string voornaam, string achternaam, string afbeelding)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            Afbeelding = afbeelding;

        }
    }
}
