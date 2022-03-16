namespace Maelstrom.Models.Objects.GameObjects
{
    internal abstract class GameObject
    {
        public string Name { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
    }
}
