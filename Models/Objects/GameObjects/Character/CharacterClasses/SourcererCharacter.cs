using Maelstrom.Models.Objects.Envirnoment;

namespace Maelstrom.Models.Objects.GameObjects.CharacterClasses
{
    internal class SourcererCharacter : ICharacter
    {
        private readonly ICharacter characterSourcerer;
        public int HitPoints
        {
            get => characterSourcerer.HitPoints;
            set => characterSourcerer.HitPoints = value;
        }
        public int ManaPoints
        {
            get => characterSourcerer.ManaPoints;
            set => characterSourcerer.ManaPoints = value;
        }

        public SourcererCharacter(ICharacter character)
        {
            characterSourcerer = character;
        }

        public void Attack(GameObject obj)
        {
            characterSourcerer.Attack(obj);
        }

        public void Move(World world, int row, int column)
        {
            characterSourcerer.Move(world, row, column);
        }

        public void Use(GameObject obj)
        {
            characterSourcerer.Use(obj);
        }
    }
}
