namespace Maelstrom.Models.Objects.GameObjects.StaticObjects.Building
{
    internal class Building : GameObject, IBuilding
    {
        public int Amount
        {
            get => Amount;
            set => Amount = value;
        }
        private bool _UnderPlayerControl = false;
        public bool UnderPlayerControl
        {
            get => _UnderPlayerControl;
            set => _UnderPlayerControl = value;
        }

        public int Generate() //todo where to
        {
            throw new System.NotImplementedException();
        }
    }
}
