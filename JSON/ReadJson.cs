using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using EksamensProjekt.Opskrifter;

namespace EksamensProjekt.JSON
{
    public class ReadJson
    {
        public static List<Opskrift> ReadOpskrifter()
        {

            try
            {
                using StreamReader reader = new("fileOpskrifter.json");
                var json = reader.ReadToEnd();
                List<Opskrift> opskrifter = JsonSerializer.Deserialize<List<Opskrift>>(json);
                return opskrifter;
            }
            catch (Exception e)
            {

                return new List<Opskrift>();
            }

        }
    }
}
