using Maelstrom.ViewModels.Base;

namespace Maelstrom.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "Maelstorm project";

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        public MainWindowViewModel()
        {

        }
    }
}
