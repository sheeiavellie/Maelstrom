using Maelstrom.Models.Objects.GameObjects;

namespace Maelstrom.Models.Objects.Envirnoment
{
    internal class World
    {
        public Cell[,] WorldGrid { get; set; }
        public int Size { get; set; }

        public World(int size)
        {
            Size = size;

            WorldGrid = new Cell[Size, Size];

            for(int x = 0; x < Size; x++)
            {
                for(int y = 0; y < Size; y++)
                {
                    WorldGrid[x, y] = new Cell();
                }
            }
        }
        public void AddObject(GameObject obj, int row, int column)
        {
            obj.Row = row;
            obj.Column = column;

            WorldGrid[row, column].PlacedObject = obj;
        }
        public void RemoveObject(GameObject obj)
        {
            WorldGrid[obj.Row, obj.Column].PlacedObject = null;

            obj.Row = -1;
            obj.Column = -1;
        }
    }
}
