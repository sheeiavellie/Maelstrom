namespace Maelstrom.Models.Objects.GameObjects.Character
{
    internal class Character : GameObject
    {
        public Character()
        {

        }
        public Character(int Row, int Column)
        {
            this.Row = Row;
            this.Column = Column;
        }
    }
}
