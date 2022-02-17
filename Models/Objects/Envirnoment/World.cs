using Maelstrom.Models.Objects.GameObjects;

namespace Maelstrom.Models.Objects.Envirnoment
{
    internal class World
    {
        public Cell[,] _WorldGrid;
        public int Size { get; set; }

        public World(int size)
        {
            Size = size;

            for(int x = 0; x < Size; x++)
            {
                for(int y = 0; y < Size; y++)
                {
                    _WorldGrid[x, y] = new Cell();
                }
            }
        }
        public void AddObject(GameObject obj, int row, int column)
        {
            obj.Row = row;
            obj.Column = column;

            _WorldGrid[row, column].PlacedObject = obj;
        }
        public void RemoveObject(GameObject obj)
        {
            _WorldGrid[obj.Row, obj.Column].PlacedObject = null;

            obj.Row = -1;
            obj.Column = -1;
        }
    }
}
