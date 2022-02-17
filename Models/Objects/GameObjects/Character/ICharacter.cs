using Maelstrom.Models.Objects.Envirnoment;

namespace Maelstrom.Models.Objects.GameObjects
{
    internal interface ICharacter
    {
        int HitPoints { get; set; }
        int ManaPoints { get; set; }
        void Move(World world, int row, int column);
        void Attack(GameObject obj);
        void Use(GameObject obj);
    }
}
