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
        public void UpdatePosition(World world, int Row, int Column)
        {
            world.WorldGrid[this.Row, this.Column].PlacedObject = null;

            this.Row = Row;
            this.Column = Column;

            world.WorldGrid[this.Row, this.Column].PlacedObject = this;
        }

        /*public void MoveLeft(World world)
        {
            world.WorldGrid[this.Row, this.Column].PlacedObject = null;
            this.Column -= 1;
            world.WorldGrid[this.Row, this.Column].PlacedObject = this;
        }
        public void MoveUp(World world)
        {
            world.WorldGrid[this.Row, this.Column].PlacedObject = null;
            this.Row += 1;
            world.WorldGrid[this.Row, this.Column].PlacedObject = this;
        }
        public void MoveRight(World world)
        {
            world.WorldGrid[this.Row, this.Column].PlacedObject = null;
            this.Column += 1;
            world.WorldGrid[this.Row, this.Column].PlacedObject = this;
        }
        public void MoveDown(World world)
        {
            world.WorldGrid[this.Row, this.Column].PlacedObject = null;
            this.Row -= 1;
            world.WorldGrid[this.Row, this.Column].PlacedObject = this;
        }*/
    }
}
