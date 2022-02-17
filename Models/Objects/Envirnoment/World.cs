using Maelstrom.Models.Objects.GameObjects;

namespace Maelstrom.Models.Objects.Envirnoment
{
    internal class World
    {
        public Cell[,] _WorldGrid;
        public int Size { get; set; }

        public World()
        {
            for(int x = 0; x < Size; x++)
            {
                for(int y = 0; y < Size; y++)
                {
                    _WorldGrid[x, y] = new Cell();
                }
            }
        }
        public void AddGameObjectToCell(GameObject obj, int row, int column)
        {
            _WorldGrid[row, column].PlacedObject = obj;
        }
    }
}
