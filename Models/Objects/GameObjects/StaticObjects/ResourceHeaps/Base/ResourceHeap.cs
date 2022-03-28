using Maelstrom.Models.Objects.Envirnoment;
using System.Collections.ObjectModel;

namespace Maelstrom.Models.Objects.GameObjects.StaticObjects.ResourceHeaps.Base
{
    internal abstract class ResourceHeap : GameObject, IUsable, IRemoveable
    {
        public abstract string ResourcePropertyName { get; }

        private int _ResourceAmount = 100;
        public int ResourceAmount
        {
            get => _ResourceAmount;
        }
        public void Remove(ObservableCollection<GameObject> c, World w)
        {
            w.WorldGrid[this.Row, this.Column].Weight = w.WorldGrid[this.Row, this.Column].BaseWeight;
            c.Remove(this);
        }

        public void Use(dynamic p)
        {
            p.GetType().GetProperty(ResourcePropertyName).SetValue(p, ResourceAmount);
        }
    }
}
