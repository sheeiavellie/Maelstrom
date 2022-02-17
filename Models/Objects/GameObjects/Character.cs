using System;

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

        public void Move(int row, int column)
        {
            throw new NotImplementedException();
        }

        public void Use(GameObject obj)
        {
            throw new NotImplementedException();
        }
    }
}
