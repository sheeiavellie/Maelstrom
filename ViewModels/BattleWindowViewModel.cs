using Maelstrom.Infrastructure.Commands;
using Maelstrom.Models.Objects.Envirnoment;
using Maelstrom.Models.Objects.GameObjects;
using Maelstrom.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Maelstrom.ViewModels
{
    internal class BattleWindowViewModel : ViewModel
    {
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

        #region Player Controls

        #region Right
        public ICommand PlayerMoveRightCommand { get; }
        private bool CanPlayerMoveRightCommandExecute(object p)
        {
            if (PColumn < 4)
                return true;
            return false;
        }
        private void OnPlayerMoveRightCommandExecuted(object p)
        {
            PColumn += 1;
            LogValue = PRow.ToString() + "; " + PColumn.ToString();
        }
        #endregion

        #region Left
        public ICommand PlayerMoveLeftCommand { get; }
        private bool CanPlayerMoveLeftCommandExecute(object p)
        {
            if (PColumn > 0)
                return true;
            return false;
        }
        private void OnPlayerMoveLeftCommandExecuted(object p)
        {
            PColumn -= 1;
            LogValue = PRow.ToString() + "; " + PColumn.ToString();
        }
        #endregion

        #region Up
        public ICommand PlayerMoveUpCommand { get; }
        private bool CanPlayerMoveUpCommandExecute(object p)
        {
            if (PRow > 0 )
                return true;
            return false;
        }
        private void OnPlayerMoveUpCommandExecuted(object p)
        {
            PRow -= 1;
            LogValue = PRow.ToString() + "; " + PColumn.ToString();
        }
        #endregion

        #region Down
        public ICommand PlayerMoveDownCommand { get; }
        private bool CanPlayerMoveDownCommandExecute(object p)
        {
            if (PRow < 4)
                return true;
            return false;
        }
        private void OnPlayerMoveDownCommandExecuted(object p)
        {
            
            PRow += 1;
            LogValue = PRow.ToString() + "; " + PColumn.ToString();
        }
        #endregion 

        #endregion

        private string _B64;
        public string B64
        {
            get => _B64;
            set => Set(ref _B64, value);
        }

        private string _LogValue;
        public string LogValue
        {
            get => _LogValue;
            set => Set(ref _LogValue, value);
        }

        private BattleMap map;
        private BattleMapGrid battlemapgrid;

        private ObservableCollection<GameObject> _GameObjects;
        public ObservableCollection<GameObject> GameObjects
        {
            get => _GameObjects;
            set => Set(ref _GameObjects, value);
        }

        private string _RuinsTexture = "../../Data/Resources/Textures/ruins.png";
        public string RuinsTexture
        {
            get => _RuinsTexture;
            set => Set(ref _RuinsTexture, value);
        }

        public BattleWindowViewModel()
        {
            PColumn = 1;
            PRow = 1;

            map = new BattleMap("../../../Data/Resources/Maps/BattleMaps/battlemap_test.json");
            battlemapgrid = new BattleMapGrid(map);
            GameObjects = map.ObjectsViewModel;

            _B64 = map.Background;


            LogValue = "Initialized";

            PlayerMoveRightCommand = new RelayCommand(OnPlayerMoveRightCommandExecuted, CanPlayerMoveRightCommandExecute);
            PlayerMoveLeftCommand = new RelayCommand(OnPlayerMoveLeftCommandExecuted, CanPlayerMoveLeftCommandExecute);
            PlayerMoveUpCommand = new RelayCommand(OnPlayerMoveUpCommandExecuted, CanPlayerMoveUpCommandExecute);
            PlayerMoveDownCommand = new RelayCommand(OnPlayerMoveDownCommandExecuted, CanPlayerMoveDownCommandExecute);

        }
    }
}
