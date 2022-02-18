using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maelstrom.Models.Objects.GameObjects.StaticObjects.Building
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
