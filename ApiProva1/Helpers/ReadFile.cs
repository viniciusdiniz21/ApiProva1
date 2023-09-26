using ApiProva1.Model;
using System.Text.Json;

namespace ApiProva1.Helpers
{
    public static class ReadFile
    {
        public static List<Carta> Read()
        {
            string fileName = "cartas.json";
            string jsonString = File.ReadAllText(fileName);
            List<Carta> cartas = JsonSerializer.Deserialize<List<Carta>>(jsonString)!;
            return cartas;
        }
    }
}
