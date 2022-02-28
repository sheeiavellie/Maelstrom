using Maelstrom.Models.Objects.GameObjects;
using Maelstrom.Services.MapLoaderManager;
using System;
using System.Collections.ObjectModel;

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
        public ObservableCollection<GameObject> ObjectsViewModel { get; set; }
        #endregion

        #region Background
        public string BackgroundImage { get; set; }

        #endregion

        private IMapLoaderManager mapLoaderManager;
        public Map(string mapName)
        {
            mapLoaderManager = new MapLoaderManager();
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
            ObjectsViewModel = new ObservableCollection<GameObject>();

            for (int i = 0; i < objects_count; i++)
            {
                string x = mapLoaderManager.ReadMapFromFile()["objects"][i]["type"];
                GameObject obj = (GameObject)Activator.CreateInstance(Type.GetType(x));

                obj.Row = mapLoaderManager.ReadMapFromFile()["objects"][i]["row"];
                obj.Column = mapLoaderManager.ReadMapFromFile()["objects"][i]["column"];

                Objects[mapLoaderManager.ReadMapFromFile()["objects"][i]["row"], mapLoaderManager.ReadMapFromFile()["objects"][i]["column"]] = obj;
                ObjectsViewModel.Add(obj);

            }
            BackgroundImage = mapLoaderManager.ReadMapFromFile()["background"];
        }
    }
}