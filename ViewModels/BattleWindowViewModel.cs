using Maelstrom.Infrastructure.Commands;
using Maelstrom.ViewModels.Base;
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
            if (PColumn < 9)
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
            if (PRow < 9)
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



        private string _LogValue;
        public string LogValue
        {
            get => _LogValue;
            set => Set(ref _LogValue, value);
        }


        public BattleWindowViewModel()
        {
            PColumn = 1;
            PRow = 1;

            LogValue = "Initialized";

            PlayerMoveRightCommand = new RelayCommand(OnPlayerMoveRightCommandExecuted, CanPlayerMoveRightCommandExecute);
            PlayerMoveLeftCommand = new RelayCommand(OnPlayerMoveLeftCommandExecuted, CanPlayerMoveLeftCommandExecute);
            PlayerMoveUpCommand = new RelayCommand(OnPlayerMoveUpCommandExecuted, CanPlayerMoveUpCommandExecute);
            PlayerMoveDownCommand = new RelayCommand(OnPlayerMoveDownCommandExecuted, CanPlayerMoveDownCommandExecute);

        }
    }
}
