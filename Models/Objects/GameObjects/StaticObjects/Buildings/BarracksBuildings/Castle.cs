using Maelstrom.Models.Objects.GameObjects.StaticObjects.Buildings.BarracksBuildings.Base;
using Maelstrom.Services.DialogUnitsRecruiting;

namespace Maelstrom.Models.Objects.GameObjects.StaticObjects.Buildings.BarracksBuildings
{
    internal class Castle : BarracksBuilding, IUsable
    {
        public void Use(dynamic p)
        {
            var dialog = new UnitsRecruitingViewModel("Unirec");
            p._dialogService.OpenDialog(dialog);
        }
    }
}
