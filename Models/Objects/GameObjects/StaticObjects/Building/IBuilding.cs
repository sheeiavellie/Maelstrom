namespace Maelstrom.Models.Objects.GameObjects.StaticObjects.Building
{
    internal interface IBuilding
    {
        int Amount { get; set; }
        bool UnderPlayerControl { get; set; }

        int Generate(); //todo where to
    }
}
