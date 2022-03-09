namespace Maelstrom.Models.Objects.Envirnoment
{
    internal class BattleMapGrid
    {
        public BattleMapCell[,] Grid { get; set; }
        public int Size { get; set; }
        public BattleMapGrid(BattleMap map)
        {
            Size = map.Size;

            Grid = new BattleMapCell[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for(int j = 0; j < Size; j++)
                {
                    Grid[i, j] = new BattleMapCell(map.Objects[i, j]);
                }
            }
        }
    }
}
