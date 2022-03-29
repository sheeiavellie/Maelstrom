using Maelstrom.ViewModels.Base;

namespace Maelstrom.Services.DialogService
{
    internal abstract class DialogViewModel<T> : ViewModel
    {
        public string Title { get; set; }
        public T DialogResult { get; set; }

        public DialogViewModel()
        {

        }
        public DialogViewModel(string title)
        {
            Title = title;
        }

        public void CloseDialog(IDialogWindow d, T res)
        {
            DialogResult = res;
            if (d != null)
                d.DialogResult = true;
        }
    }
}
