using Maelstrom.Models.Objects.Envirnoment;
using System.Collections.ObjectModel;

namespace Maelstrom.Models.Objects.GameObjects.StaticObjects
{
    internal interface IRemoveable
    {
        void Remove(ObservableCollection<GameObject> c, World w);
    }
}
