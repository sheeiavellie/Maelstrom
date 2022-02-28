using Maelstrom.Infrastructure.Commands;
using Maelstrom.Models.Objects.Envirnoment;
using Maelstrom.Models.Objects.GameObjects;
using Maelstrom.Models.Objects.GameObjects.Character;
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

        #region Background image
        private string _B64;
        public string B64
        {
            get => _B64;
            set => Set(ref _B64, value);
        }
        #endregion




        #region Envirnoment
        private Map map = new Map("map_test.json");
        private World world; 
        #endregion

        public MainWindowViewModel()
        {
            GameObjects = map.ObjectsViewModel;
            world = new World(map);
            _B64 = map.BackgroundImage;
            GameObjects[0].Name = "bob";

            
        }
    }
}
