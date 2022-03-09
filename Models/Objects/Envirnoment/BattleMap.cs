using Maelstrom.Models.Objects.GameObjects;
using Maelstrom.Services.MapLoaderManager;
using System;
using System.Collections.ObjectModel;

namespace Maelstrom.Models.Objects.Envirnoment
{
    internal class BattleMap
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public string Background { get; set; }
        public GameObject[,] Objects { get; set; }
        public ObservableCollection<GameObject> ObjectsViewModel { get; set; }


        private IMapLoaderManager mapLoaderManager;

        public BattleMap(string MapName)
        {
            mapLoaderManager = new MapLoaderManager();
            mapLoaderManager.JsonMapFileIn = MapName;

            Name = mapLoaderManager.ReadMapFromFile()["name"];

            Size = mapLoaderManager.ReadMapFromFile()["size"];

            Background = mapLoaderManager.ReadMapFromFile()["background"];

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
        }
    }
}
