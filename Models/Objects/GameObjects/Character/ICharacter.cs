using Maelstrom.Models.Objects.Envirnoment;

namespace Maelstrom.Models.Objects.GameObjects.Character
{
    internal interface ICharacter
    {
        public string Name { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        int HitPoints { get; set; }
        int ManaPoints { get; set; }
        void MoveLeft(World world);
        void MoveUp(World world);
        void MoveRight(World world);
        void MoveDown(World world);
    }
}
