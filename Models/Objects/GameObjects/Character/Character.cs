using System;
using Maelstrom.Models.Objects.Envirnoment;

namespace Maelstrom.Models.Objects.GameObjects
{
    internal class Character : GameObject, ICharacter
    {
        public int ManaPoints { get; set; }
        public int HitPoints { get; set; }

        public void Attack(GameObject obj)
        {
            throw new NotImplementedException();
        }

        public void Move(World world, int row, int column)
        {
            if (Row != -1 && Column != -1)
                world.RemoveObject(this);
            world.AddObject(this, row, column);
        }

        public void Use(GameObject obj)
        {
            throw new NotImplementedException();
        }
    }
}
