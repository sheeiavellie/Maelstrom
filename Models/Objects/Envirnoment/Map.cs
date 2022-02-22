using Maelstrom.Models.Objects.GameObjects;
using Maelstrom.Services.MapLoaderManager;
using System;

namespace Maelstrom.Models.Objects.Envirnoment
{
    internal class Map
    {
        #region Name
        public string Name { get; set; }

        #endregion

        #region Size
        public int Size { get; set; }
        #endregion

        #region Weights
        public int[,] Weights { get; set; }
        #endregion

        #region Objects
        public GameObject[,] Objects { get; set; }
        #endregion

        #region Background
        public string BackgroundImage { get; set; }

        #endregion

        private IMapLoaderManager mapLoaderManager;
        public Map(string mapName)
        {
            mapLoaderManager.JsonMapFileIn = mapName;

            Name = mapLoaderManager.ReadMapFromFile()["name"];

            Size = mapLoaderManager.ReadMapFromFile()["size"];

            Weights = new int[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Weights[i, j] = mapLoaderManager.ReadMapFromFile()["weights"][i][j];
                }
            }

            int objects_count = mapLoaderManager.ReadMapFromFile()["objects_count"];

            Objects = new GameObject[Size, Size];

            for (int i = 0; i < objects_count; i++)
            {
                object obj = Activator.CreateInstance(Type.GetType(mapLoaderManager.ReadMapFromFile()["objects"][i]["type"]),
                    mapLoaderManager.ReadMapFromFile()["objects"][i]["row"],
                    mapLoaderManager.ReadMapFromFile()["objects"][i]["column"]);

                    Objects[mapLoaderManager.ReadMapFromFile()["objects"][i]["row"], mapLoaderManager.ReadMapFromFile()["objects"][i]["column"]] = (GameObject)obj;
            }

            BackgroundImage = mapLoaderManager.ReadMapFromFile()["background"];
        }
    }
}