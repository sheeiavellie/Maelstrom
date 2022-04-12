using Maelstrom.Services.DialogService;
using System.Collections.ObjectModel;

namespace Maelstrom.Services.DialogUnitsRecruiting
{
    internal class UnitsRecruitingViewModel : DialogViewModel
    {
        private ObservableCollection<string> _CardSource;
        public ObservableCollection<string> CardSource
        {
            get => _CardSource;
            set => Set(ref _CardSource, value);
        }

        private int _Gold;
        public int Gold
        {
            get => _Gold;
            set => Set(ref _Gold, value);
        }

        private int _GoldCost;
        public int GoldCost
        {
            get => _GoldCost;
            set => Set(ref _GoldCost, value);
        }
        private int _ManaCost;
        public int ManaCost
        {
            get => _ManaCost;
            set => Set(ref _ManaCost, value);
        }


        public UnitsRecruitingViewModel(string t, int gc, int mc, ObservableCollection<string> cs) : base(t)
        {
            CardSource = cs;
            GoldCost = gc;
            ManaCost = mc;
        }
    }
}
