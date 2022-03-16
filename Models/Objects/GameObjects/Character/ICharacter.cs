using Maelstrom.Models.Objects.Envirnoment;

namespace Maelstrom.Models.Objects.GameObjects.Character
{
    internal interface ICharacter
    {
        public string Name { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
    }
}
