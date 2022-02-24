using Maelstrom.Infrastructure.Commands;
using Maelstrom.Models.Objects.GameObjects;
using Maelstrom.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Media;

namespace Maelstrom.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Title
        public string _Title = "Maelstorm project";
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion

        #region GameObjects
        private ObservableCollection<GameObject> _GameObjects;
        public ObservableCollection<GameObject> GameObjects
        {
            get => _GameObjects;
            set => Set(ref _GameObjects, value);
        }
        #endregion



        /*public ICommand TestCommand { get; }
        private void OnTestCommandExecuted(object p)
        {
        }
        private bool CanTestCommandExecute(object p) => true;*/

        public MainWindowViewModel()
        {
            //TestCommand = new RelayCommand(OnTestCommandExecuted, CanTestCommandExecute);

            GameObjects = new ObservableCollection<GameObject>();
        }
    }
}
