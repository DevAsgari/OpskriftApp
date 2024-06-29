using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EksamensProjekt.Opskrifter;

namespace EksamensProjekt.Factories
{
    internal class ForretFactory : IOpskriftFactory
    {
        public Opskrift CreateOpskrift(string titel, List<Ingrediens> ingredienser, string udførelsel)
        {
           return new Forret(
            titel,
            ingredienser,
            udførelsel);
        }
    }
}
