using Maelstrom.Infrastructure.Commands;
using Maelstrom.Infrastructure.Properties;
using Maelstrom.ViewModels.Base;
using System;
using System.Windows.Input;

namespace Maelstrom.Services.DialogService
{
    internal abstract class DialogViewModel : ViewModel, IWindowCloser
    {
        public string Title { get; set; }


        public Action Close { get; set; }
        public bool CanClose
        {
            get => true;
        }



        public ICommand WindowClose { get; }
        public bool CanWindowCloseExecute(object p)
        {
            return true;
        }
        public void OnWindowCloseExecuted(object p)
        {
            Close?.Invoke();
        }

        public DialogViewModel()
        {

        }

        
        public DialogViewModel(string title)
        {
            Title = title;
            WindowClose = new RelayCommand(OnWindowCloseExecuted, CanWindowCloseExecute);
        }
    }
}
