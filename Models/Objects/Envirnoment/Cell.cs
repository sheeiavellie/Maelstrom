using Maelstrom.Models.Objects.GameObjects;

namespace Maelstrom.Models.Objects.Envirnoment
{
    internal class Cell
    {
        private GameObject _PlacedObject;
        public GameObject PlacedObject
        {
            get => _PlacedObject;
            set
            {
                _PlacedObject = value;
                if(value != null)
                    CurrentlyOccupied = true;
            }
        }
        private int _Weight;
        public int Weight
        {
            get => _Weight;
            set => _Weight = value;
        }
        private bool _CurrentlyOccupied = false;
        public bool CurrentlyOccupied
        {
            get => _CurrentlyOccupied;
            set => _CurrentlyOccupied = value;
        }

        public Cell()
        {

        }
    }
}
