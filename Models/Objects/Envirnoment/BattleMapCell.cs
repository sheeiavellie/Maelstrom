using Maelstrom.Models.Objects.GameObjects;

namespace Maelstrom.Models.Objects.Envirnoment
{
    internal class BattleMapCell
    {
        public bool IsFree { get; set; }

        private GameObject _PlacedObject;
        public GameObject PlacedObject
        {
            get => _PlacedObject;
            set
            {
                _PlacedObject = value;
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
