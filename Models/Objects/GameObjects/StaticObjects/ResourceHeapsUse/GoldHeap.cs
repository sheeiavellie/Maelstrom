namespace Maelstrom.Models.Objects.GameObjects.StaticObjects.ResourceHeaps
{
    internal class GoldHeap : GameObject, IUsable
    {
        private int _GoldAmount = 100;
        public int GoldAmount
        {
            get => _GoldAmount;
        }

        public void Use()
        {
        }

        public int Use(int Counter)
        {
            return Counter + GoldAmount;
        }
    }
}
