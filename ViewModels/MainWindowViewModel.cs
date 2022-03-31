using Maelstrom.Infrastructure.Commands;
using Maelstrom.Models.Indicators;
using Maelstrom.Models.Objects.Envirnoment;
using Maelstrom.Models.Objects.GameObjects;
using Maelstrom.Models.Objects.GameObjects.StaticObjects;
using Maelstrom.Services.DialogService;
using Maelstrom.Services.TextureLoaderManager;
using Maelstrom.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Linq;
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

        #region Mana
        private int _Mana;
        public int Mana
        {
            get => _Mana;
            set => Set(ref _Mana, value);
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

        #region Player view direction
        private int _PlayerViewDirectionRow;
        public int PlayerViewDirectionRow
        {
            get => _PlayerViewDirectionRow;
            set => Set(ref _PlayerViewDirectionRow, value);
        }

        private int _PlayerViewDirectionColumn;
        public int PlayerViewDirectionColumn
        {
            get => _PlayerViewDirectionColumn;
            set => Set(ref _PlayerViewDirectionColumn, value);
        } 
        #endregion

        #endregion

        #region Envirnoment

        private Map map;
        private World world;

        #endregion

        #region Services

        private ITextureLoaderManager _textureManager;
        public IDialogService _dialogService;

        #endregion

        #region Player Controls

        #region Right
        public ICommand PlayerMoveRightCommand { get; }
        private bool CanPlayerMoveRightCommandExecute(object p)
        {
            PlayerViewDirectionColumn = PColumn + 1;
            PlayerViewDirectionRow = PRow;

            if (PColumn < map.Size - 1 && world.WorldGrid[PRow, PColumn + 1].Weight != 0)
                return true;
            return false;
        }
        private void OnPlayerMoveRightCommandExecuted(object p)
        {
            world.WorldGrid[PRow, PColumn + 1].PlacedObject = world.WorldGrid[PRow, PColumn].PlacedObject;
            world.WorldGrid[PRow, PColumn].PlacedObject = null;
            PColumn += 1;

            PlayerViewDirectionColumn = PColumn + 1;
            PlayerViewDirectionRow = PRow;
        }
        #endregion

        #region Left
        public ICommand PlayerMoveLeftCommand { get; }
        private bool CanPlayerMoveLeftCommandExecute(object p)
        {
            PlayerViewDirectionColumn = PColumn - 1;
            PlayerViewDirectionRow = PRow;

            if (PColumn > 0 && world.WorldGrid[PRow, PColumn - 1].Weight != 0)
                return true;
            return false;
        }
        private void OnPlayerMoveLeftCommandExecuted(object p)
        {
            world.WorldGrid[PRow, PColumn - 1].PlacedObject = world.WorldGrid[PRow, PColumn].PlacedObject;
            world.WorldGrid[PRow, PColumn].PlacedObject = null;
            PColumn -= 1;

            PlayerViewDirectionColumn = PColumn - 1;
            PlayerViewDirectionRow = PRow;
        }
        #endregion

        #region Up
        public ICommand PlayerMoveUpCommand { get; }
        private bool CanPlayerMoveUpCommandExecute(object p)
        {
            PlayerViewDirectionRow = PRow - 1;
            PlayerViewDirectionColumn = PColumn;

            if (PRow > 0 && world.WorldGrid[PRow - 1, PColumn].Weight != 0)
                return true;
            return false;
        }
        private void OnPlayerMoveUpCommandExecuted(object p)
        {
            world.WorldGrid[PRow - 1, PColumn].PlacedObject = world.WorldGrid[PRow, PColumn].PlacedObject;
            world.WorldGrid[PRow, PColumn].PlacedObject = null;
            PRow -= 1;

            PlayerViewDirectionRow = PRow - 1;
            PlayerViewDirectionColumn = PColumn;
        }
        #endregion

        #region Down
        public ICommand PlayerMoveDownCommand { get; }
        private bool CanPlayerMoveDownCommandExecute(object p)
        {
            PlayerViewDirectionRow = PRow + 1;
            PlayerViewDirectionColumn = PColumn;

            if (PRow < map.Size - 1 && world.WorldGrid[PRow + 1, PColumn].Weight != 0)
                return true;
            return false;
        }
        private void OnPlayerMoveDownCommandExecuted(object p)
        {
            world.WorldGrid[PRow + 1, PColumn].PlacedObject = world.WorldGrid[PRow, PColumn].PlacedObject;
            world.WorldGrid[PRow, PColumn].PlacedObject = null;
            PRow += 1;

            PlayerViewDirectionRow = PRow + 1;
            PlayerViewDirectionColumn = PColumn;
        }
        #endregion

        #region Use
        public ICommand PlayerUseCommand { get; }
        private bool CanPlayerUseCommandExecute(object p)
        {
            foreach(var obj in GameObjects.ToList().OfType<IUsable>())
            {
                if(obj.Row == PlayerViewDirectionRow && obj.Column == PlayerViewDirectionColumn)
                {
                    return true;
                }
            }
            return false;
        }
        private void OnPlayerUseCommandExecuted(object p)
        {
            foreach (var obj in GameObjects.ToList().OfType<IUsable>())
            {
                if (obj.Row == PlayerViewDirectionRow && obj.Column == PlayerViewDirectionColumn)
                {
                    obj.Use(this);

                    if (obj is IRemoveable)
                    {
                        var removableObj = obj as IRemoveable;
                        removableObj.Remove(GameObjects, world);
                    }
                }
            }
        }
        #endregion

        #endregion

        #region Textures

        private ObservableCollection<string> _Textures;
        public ObservableCollection<string> Textures
        {
            get => _Textures;
            set => Set(ref _Textures, value);
        }

        #region Player Texture

        private string _PlayerTexture;
        public string PlayerTexture
        {
            get => _PlayerTexture;
            set => Set(ref _PlayerTexture, value);
        }
        #endregion 

       

        #endregion


        private ObservableCollection<UnitUnderPlayerControl> _UnitsUnderPlayerControl;
        public ObservableCollection<UnitUnderPlayerControl> UnitsUnderPlayerControl
        {
            get => _UnitsUnderPlayerControl;
            set => Set(ref _UnitsUnderPlayerControl, value);
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

            _textureManager = new TextureLoaderManager();
            _dialogService = new DialogService();

            GameObjects = new ObservableCollection<GameObject>(map.ObjectsViewModel.ToList().Where(i => i.GetType().Name != "Character"));

            Gold = 0;
            Mana = 0;

            PRow = map.ObjectsViewModel[0].Row;
            PColumn = map.ObjectsViewModel[0].Column;

            PlayerViewDirectionRow = PRow;
            PlayerViewDirectionColumn = PColumn + 1;

            B64 = map.BackgroundImage;

            Textures = new ObservableCollection<string>();

            Textures.Add(_textureManager.LoadTexture("error.png"));
            foreach (var obj in GameObjects)
            {
                if (!Textures.Contains(_textureManager.LoadTexture(obj.GetType().Name + ".png")))
                    Textures.Add(_textureManager.LoadTexture(obj.GetType().Name + ".png"));
            }

            PlayerTexture = _textureManager.LoadTexture("char_test_tex.png");
        }
    }
}
