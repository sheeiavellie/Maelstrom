using Maelstrom.Models.Objects.Envirnoment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maelstrom.Models.Objects.GameObjects.StaticObjects.Building.TreasuryBuilding.Base
{
    internal abstract class TreasuryBuilding : Building, ITreasuryBuilding
    {
        public BattleMap map { get; } 
    }
}
