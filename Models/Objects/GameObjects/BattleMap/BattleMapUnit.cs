namespace Maelstrom.Models.Objects.GameObjects.BattleMap
{
    internal abstract class BattleMapUnit : GameObject
    {
        public int HitPoints { get; set; }
        public int AttackStrenght { get; set; }
    }
}
