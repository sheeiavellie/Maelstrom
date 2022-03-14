using System;
using Maelstrom.Models.Objects.Envirnoment;

namespace Maelstrom.Models.Objects.GameObjects.Character
{
    internal class Character : GameObject, ICharacter
    {
        public int ManaPoints { get; set; }
        public int HitPoints { get; set; }
        
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
