using System;
using Maelstrom.Models.Objects.Envirnoment;

namespace Maelstrom.Models.Objects.GameObjects
{
    internal class Character : GameObject, ICharacter
    {
        public int ManaPoints { get; set; }
        public int HitPoints { get; set; }

        public Character(int Row, int Column)
        {
            this.Row = Row;
            this.Column = Column;
        }
        public void Attack(GameObject obj)
        {
            throw new NotImplementedException();
        }

        public void Move(World world, int row, int column)
        {

        }

        public void Use(GameObject obj)
        {
            throw new NotImplementedException();
        }
    }
}
