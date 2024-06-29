using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EksamensProjekt.Opskrifter
{
    internal class Dessert : Opskrift
    {
        public Dessert() { }
        public Dessert(string titel, List<Ingrediens> ingredienser, string udførelsel) : base(titel, ingredienser, udførelsel, "Dessert")
        {

        }

        public override bool sundMadret()
        {
            return !Ingredienser.Any(ingrediens => ingrediens.IngrediensNavn.Contains("sukker"));
        }
    }
}
