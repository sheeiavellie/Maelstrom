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
        public void MoveLeft(World world)
        {
            if(this.Column != 0)
            {
                world.WorldGrid[this.Row, this.Column].PlacedObject = null;
                this.Column -= 1;
                world.WorldGrid[this.Row, this.Column].PlacedObject = this;
            }
        }
        public void MoveUp(World world)
        {
            if (this.Row != 0)
            {
                world.WorldGrid[this.Row, this.Column].PlacedObject = null;
                this.Row += 1;
                world.WorldGrid[this.Row, this.Column].PlacedObject = this;
            }
        }
        public void MoveRight(World world)
        {
            if (this.Column < world.Size - 1)
            {
                world.WorldGrid[this.Row, this.Column].PlacedObject = null;
                this.Column += 1;
                world.WorldGrid[this.Row, this.Column].PlacedObject = this;
            }
        }
        public void MoveDown(World world)
        {
            if (this.Row < world.Size - 1)
            {
                world.WorldGrid[this.Row, this.Column].PlacedObject = null;
                this.Row -= 1;
                world.WorldGrid[this.Row, this.Column].PlacedObject = this;
            }
        }
    }
}
