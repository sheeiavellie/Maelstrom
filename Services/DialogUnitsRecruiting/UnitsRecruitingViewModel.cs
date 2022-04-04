using Maelstrom.Services.DialogService;
using System.Collections.ObjectModel;

namespace Maelstrom.Services.DialogUnitsRecruiting
{
    internal class UnitsRecruitingViewModel : DialogViewModel<string>
    {
        private ObservableCollection<string> _CardSource;
        public ObservableCollection<string> CardSource
        {
            get => _CardSource;
            set => Set(ref _CardSource, value);
        }


        public UnitsRecruitingViewModel(string t, ObservableCollection<string> cs) : base(t)
        {
            CardSource = cs;
        }
    }
}
