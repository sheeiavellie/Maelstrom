using Newtonsoft.Json;
using System.IO;

namespace Maelstrom.Services.MapLoaderManager
{
    internal class MapLoaderManager : IMapLoaderManager
    {
        public string JsonMapFileIn { get; set; }

        public dynamic ReadMapFromFile()// => JsonConvert.DeserializeObject(File.ReadAllText(JsonMapFileIn)) ?? null;
        {
            if (JsonMapFileIn != null)
            {
                dynamic jsonMapFile = JsonConvert.DeserializeObject(File.ReadAllText(JsonMapFileIn));

                return jsonMapFile;
            }
            return null;
        }
    }
}
