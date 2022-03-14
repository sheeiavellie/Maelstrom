using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maelstrom.Models.Objects.GameObjects.StaticObjects.ResourceHeaps
{
    internal class GoldHeap : GameObject
    {
        private int _GoldAmount = 100;
        public int GoldAmount
        {
            get => _GoldAmount;
        }
    }
}
