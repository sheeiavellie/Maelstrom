using Maelstrom.Services.MapLoaderManager;

namespace Maelstrom.Models.Objects.Envirnoment
{
    internal class Map
    {
        #region Name
        public string Name { get; set; }

        #endregion

        #region Weights
        public int[,] Weights { get; set; }
        #endregion

        #region Objects
        public objectInJson[] Objects { get; set; }
        public struct objectInJson
        {
            public string type;
            public int xPosition;
            public int yPosition;
        }
        #endregion

        #region Background
        public string BackgroundImage { get; set; }

        #endregion

        private IMapLoaderManager mapLoaderManager;
        public Map(string mapName)
        {
            mapLoaderManager.JsonMapFileIn = mapName;

            Name = mapLoaderManager.ReadMapFromFile()["name"];

            int size = mapLoaderManager.ReadMapFromFile()["size"];

            Weights = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Weights[i, j] = mapLoaderManager.ReadMapFromFile()["weights"][i][j];
                }
            }

            int objects_count = mapLoaderManager.ReadMapFromFile()["objects_count"];

            Objects = new objectInJson[objects_count];

            for (int i = 0; i < objects_count; i++)
            {
                objectInJson obj;
                obj.type = mapLoaderManager.ReadMapFromFile()["objects"][i]["type"];
                obj.xPosition = mapLoaderManager.ReadMapFromFile()["objects"][i]["xPosition"];
                obj.yPosition = mapLoaderManager.ReadMapFromFile()["objects"][i]["yPosition"];

                Objects[i] = obj;
            }

            BackgroundImage = mapLoaderManager.ReadMapFromFile()["background"];
        }
    }
}