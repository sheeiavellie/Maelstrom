using Maelstrom.Models.Objects.GameObjects;

namespace Maelstrom.Models.Objects.Envirnoment
{
    internal class BattleMapCell
    {
        public bool IsFree { get; set; }
        public GameObject PlacedObject
        {
            get => PlacedObject;
            set
            {
                PlacedObject = value;
                if(value != null)
                    IsFree = false;
            }
        }
        public BattleMapCell(GameObject PlacedObject)
        {
            IsFree = true;
            this.PlacedObject = PlacedObject;
        }
    }
}
