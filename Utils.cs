using CsvHelper;
using EksamensProjekt.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensProjekt
{
    public class Utils
    {
        static public Dictionary<string, IOpskriftFactory> factories = new Dictionary<string, IOpskriftFactory>();

        static Utils()
        {
            factories.Add("Forret", new ForretFactory());
            factories.Add("Hovedret", new HovedretFactory());
            factories.Add("Dessert", new DessertFactory());
        }
    }
}
