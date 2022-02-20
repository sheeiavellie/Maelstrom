using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Maelstrom.Services.MapLoader
{
    internal class MapLoader
    {
        public static void ReadMap(string jsonMapFileIn)
        {
            dynamic jsonMapFile = JsonConvert.DeserializeObject(File.ReadAllText(jsonMapFileIn));
        }
    }
}
