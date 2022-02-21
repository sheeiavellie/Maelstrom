using Newtonsoft.Json;
using System.IO;

namespace Maelstrom.Services.MapLoaderManager
{
    internal class MapLoaderManager : IMapLoaderManager
    {
        public string JsonMapFileIn { get; set; }

        public dynamic ReadMapFromFile()
        {
            dynamic jsonMapFile = JsonConvert.DeserializeObject(File.ReadAllText(JsonMapFileIn));

            return jsonMapFile;
        }
    }
}
