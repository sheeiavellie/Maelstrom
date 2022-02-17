using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maelstrom.Models.Objects.GameObjects
{
    internal interface ICharacter
    {
        int HitPoints { get; set; }
        int ManaPoints { get; set; }
        void Move(int row, int column);
        void Attack(GameObject obj);
        void Use(GameObject obj);
    }
}
