using CsvHelper;
using CsvHelper.Configuration;
using EksamensProjekt.Opskrifter;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace EksamensProjekt.JSON
{
    public static class WriteJson
    {
        public static void WriteJsonFile(List<Opskrift> opskrifter)
        {
            string jsonString = JsonSerializer.Serialize(opskrifter);

            File.WriteAllText("fileOpskrifter.json", jsonString);
        }
    }
}
