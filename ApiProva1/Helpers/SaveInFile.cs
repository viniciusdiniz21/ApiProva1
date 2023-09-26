using ApiProva1.Model;
using System.Reflection;
using System.Text.Json;

namespace ApiProva1.Helpers
{
    public static class SaveInFile
    {
        public static Carta Save(Carta data)
        {
            //Gambiarra pq esqueci como salva lista no json
            var cartas = ReadFile.Read();

            cartas.Add(data);

            string fileName = "cartas.json";
            string jsonString = JsonSerializer.Serialize(cartas);
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(File.ReadAllText(fileName));
            return data;
        }
    }
}
