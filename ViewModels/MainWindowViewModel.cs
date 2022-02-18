using Maelstrom.Infrastructure.Commands;
using Maelstrom.Models.Objects.Envirnoment;
using Maelstrom.Models.Objects.GameObjects;
using Maelstrom.Models.Objects.GameObjects.CharacterClasses;
using Maelstrom.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

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
        public ICommand MoveRight { get; set; }
        private bool CanMoveRightExecute(object p) => true;
        private void OnMoveRightExecuted(object p)
        {
               
        }
        public MainWindowViewModel()
        {
            MoveRight = new RelayCommand(OnMoveRightExecuted, CanMoveRightExecute);
        }
    }
}
