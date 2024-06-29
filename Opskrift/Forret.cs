using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EksamensProjekt.Opskrifter
{
    internal class Forret : Opskrift
    {
        public Forret() { }
        public Forret(string titel, List<Ingrediens> ingredienser, string udførelsel) : base(titel, ingredienser, udførelsel, "Forret")
        {
        }

        public override bool sundMadret()
        {
            return Ingredienser.Any(ingrediens => ingrediens.IngrediensNavn.Contains("laks"));
        }
    }
}
