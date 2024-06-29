using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EksamensProjekt.Opskrifter
{
    public class Ingrediens
    {
        public Ingrediens() { }
        public string IngrediensNavn { get; set; }

        public Ingrediens(string ingrediensNavn)
        {
            IngrediensNavn = ingrediensNavn;
        }

    }
}
