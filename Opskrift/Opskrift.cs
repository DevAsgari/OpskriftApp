using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EksamensProjekt.Opskrifter
{
    [JsonPolymorphic()]
    [JsonDerivedType(typeof(Forret), typeDiscriminator: "Forret")]
    [JsonDerivedType(typeof(Hovedret), typeDiscriminator: "Hovedret")]
    [JsonDerivedType(typeof(Dessert), typeDiscriminator: "Dessert")]
    public abstract class Opskrift
    {
        public string Titel { get; set; }
        public List<Ingrediens> Ingredienser { get; set; }
        public string Udførelsel { get; set; }

        public string Type { get; set; }

        public Opskrift()
        {

        }

        public Opskrift(string titel, List<Ingrediens> ingredienser, string udførelsel, string type)
        {
            Titel = titel;
            Ingredienser = ingredienser;
            Udførelsel = udførelsel;
            Type = type;
        }

        public abstract String something();

        public abstract bool sundMadret();
    }
}
