﻿using Maelstrom.Infrastructure.Commands;
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

        private string _B64 = "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";
        public string B64
        {
            get => _B64;
            set => Set(ref _B64, value);
        }

        public MainWindowViewModel()
        {
            GameObjects = new ObservableCollection<GameObject>();
        }
    }
}
