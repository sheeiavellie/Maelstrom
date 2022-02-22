using Maelstrom.Models.Objects.GameObjects;

namespace Maelstrom.Models.Objects.Envirnoment
{
    internal class World
    {
        public Cell[,] WorldGrid { get; set; }
        public int Size { get; set; }
        public World(Map map)
        {

            Size = map.Size;

            WorldGrid = new Cell[Size, Size];

            for(int x = 0; x < Size; x++)
            {
                for(int y = 0; y < Size; y++)
                {
                    Cell cell = new Cell();

                    cell.Weight = map.Weights[x, y];
                    cell.PlacedObject = map.Objects[x, y];

                    WorldGrid[x, y] = cell;
                }
            }
        }

    }
}
