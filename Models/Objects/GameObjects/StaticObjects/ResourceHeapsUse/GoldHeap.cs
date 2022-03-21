using Maelstrom.Models.Objects.Envirnoment;
using System;
using System.Collections.ObjectModel;

namespace Maelstrom.Models.Objects.GameObjects.StaticObjects.ResourceHeaps
{
    internal class GoldHeap : GameObject, IUsable, IRemoveable
    {
        private int _GoldAmount = 100;
        public int GoldAmount
        {
            get => _GoldAmount;
        }

        public void Remove(ObservableCollection<GameObject> c, World w)
        {
            c.Remove(this);
            w.WorldGrid[this.Row, this.Column].Weight = w.WorldGrid[this.Row, this.Column].BaseWeight;
        }

        public void Use(dynamic p)
        {
            p.Gold += GoldAmount;
        }
    }
}
