using Maelstrom.Data.Resources.Constants;
using Maelstrom.Models.Objects.GameObjects.StaticObjects.Buildings.BarracksBuildings.Base;
using Maelstrom.Services.DialogUnitsRecruiting;
using System.Collections.ObjectModel;
using System.IO;

namespace Maelstrom.Models.Objects.GameObjects.StaticObjects.Buildings.BarracksBuildings
{
    internal class Castle : BarracksBuilding, IUsable
    {
        public void Use(dynamic p)
        {
            p._dialogService.OpenDialog(new UnitsRecruitingViewModel("Unirec", p._textureManager.LoadAllTexturesWithPrefix("ArmyCards/", "warriors")));
        }
    }
}
