using Maelstrom.Infrastructure.Commands;
using Maelstrom.Models.Objects.Envirnoment;
using Maelstrom.Models.Objects.GameObjects;
using Maelstrom.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows.Input;

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

        #region Gold
        private int _Gold;
        public int Gold
        {
            get => _Gold;
            set => Set(ref _Gold, value);
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

        #region Player Position

        #region Player Row
        private int _PRow;
        public int PRow
        {
            get => _PRow;
            set => Set(ref _PRow, value);
        }
        #endregion

        #region Player Column
        private int _PColumn;
        public int PColumn
        {
            get => _PColumn;
            set => Set(ref _PColumn, value);
        }
        #endregion 

        #endregion

        #region Envirnoment
        private Map map;
        private World world;
        #endregion

        #region Player Controls

        #region Right
        public ICommand PlayerMoveRightCommand { get; }
        private bool CanPlayerMoveRightCommandExecute(object p)
        {
            if (PColumn < map.Size - 1 && world.WorldGrid[PRow, PColumn + 1].Weight != 0)
                return true;
            return false;
        }
        private void OnPlayerMoveRightCommandExecuted(object p)
        {
            world.WorldGrid[PRow, PColumn + 1].PlacedObject = world.WorldGrid[PRow, PColumn].PlacedObject;
            world.WorldGrid[PRow, PColumn].PlacedObject = null;
            PColumn += 1;
        }
        #endregion

        #region Left
        public ICommand PlayerMoveLeftCommand { get; }
        private bool CanPlayerMoveLeftCommandExecute(object p)
        {
            if (PColumn > 0 && world.WorldGrid[PRow, PColumn - 1].Weight != 0)
                return true;
            return false;
        }
        private void OnPlayerMoveLeftCommandExecuted(object p)
        {
            world.WorldGrid[PRow, PColumn - 1].PlacedObject = world.WorldGrid[PRow, PColumn].PlacedObject;
            world.WorldGrid[PRow, PColumn].PlacedObject = null;
            PColumn -= 1;
        }
        #endregion

        #region Up
        public ICommand PlayerMoveUpCommand { get; }
        private bool CanPlayerMoveUpCommandExecute(object p)
        {
            if (PRow > 0 && world.WorldGrid[PRow - 1, PColumn].Weight != 0)
                return true;
            return false;
        }
        private void OnPlayerMoveUpCommandExecuted(object p)
        {
            world.WorldGrid[PRow - 1, PColumn].PlacedObject = world.WorldGrid[PRow, PColumn].PlacedObject;
            world.WorldGrid[PRow, PColumn].PlacedObject = null;
            PRow -= 1;
        }
        #endregion

        #region Down
        public ICommand PlayerMoveDownCommand { get; }
        private bool CanPlayerMoveDownCommandExecute(object p)
        {
            if (PRow < map.Size - 1 && world.WorldGrid[PRow + 1, PColumn].Weight != 0)
                return true;
            return false;
        }
        private void OnPlayerMoveDownCommandExecuted(object p)
        {
            world.WorldGrid[PRow + 1, PColumn].PlacedObject = world.WorldGrid[PRow, PColumn].PlacedObject;
            world.WorldGrid[PRow, PColumn].PlacedObject = null;
            PRow += 1;
        }
        #endregion

        #region Use
        public ICommand PlayerUseCommand { get; }
        private bool CanPlayerUseCommandExecute(object p)
        {
            return true;
        }
        private void OnPlayerUseCommandExecuted(object p)
        {

        } 
        #endregion

        #endregion

        #region Player Texture
        private string _PlayerTexture = "../../Data/Resources/Textures/char_test_tex.png";
        public string PlayerTexture
        {
            get => _PlayerTexture;
            set => Set(ref _PlayerTexture, value);
        }
        #endregion

        private string _GT = "../../Data/Resources/Textures/gold_heap.gif";
        public string GoldTexture
        {
            get => _GT;
            set => Set(ref _GT, value);
        }




        public MainWindowViewModel()
        {
            #region Commands Declaration

            PlayerMoveRightCommand = new RelayCommand(OnPlayerMoveRightCommandExecuted, CanPlayerMoveRightCommandExecute);
            PlayerMoveLeftCommand = new RelayCommand(OnPlayerMoveLeftCommandExecuted, CanPlayerMoveLeftCommandExecute);
            PlayerMoveUpCommand = new RelayCommand(OnPlayerMoveUpCommandExecuted, CanPlayerMoveUpCommandExecute);
            PlayerMoveDownCommand = new RelayCommand(OnPlayerMoveDownCommandExecuted, CanPlayerMoveDownCommandExecute);
            PlayerUseCommand = new RelayCommand(OnPlayerUseCommandExecuted, CanPlayerUseCommandExecute); 

            #endregion

            map = new Map("../../../Data/Resources/Maps/map_test.json");
            world = new World(map);

            GameObjects = map.ObjectsViewModel;

            

            Gold = 0;

            PRow = GameObjects[0].Row;
            PColumn = GameObjects[0].Column;

            _B64 = map.BackgroundImage;
    }
}
}
