﻿namespace Maelstrom.Models.Objects.GameObjects.StaticObjects.Buildings
{
    internal class BuildingSource : GameObject, IBuildingSource
    {
        public int ResourceAmount
        {
            get => ResourceAmount;
            set => ResourceAmount = value;
        }
    }
}