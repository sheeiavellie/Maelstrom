namespace Maelstrom.Models.Objects.GameObjects.CharacterClasses
{
    class WarriorCharacter
    {
        private readonly ICharacter character;
        public int HitPoints
        {
            get => character.HitPoints;
            set => character.HitPoints = value;
        }
        public int ManaPoints
        {
            get => character.ManaPoints;
            set => character.ManaPoints = value;
        }

        public WarriorCharacter(ICharacter character)
        {
            this.character = character;
        }

        public void Attack(GameObject obj)
        {
            character.Attack(obj);
        }

        public void Move(int row, int column)
        {
            character.Move(row, column);
        }

        public void Use(GameObject obj)
        {
            character.Use(obj);
        }
    }
}
