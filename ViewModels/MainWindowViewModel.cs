using Maelstrom.ViewModels.Base;

namespace Maelstrom.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "title_plchldr";

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
    }
}
