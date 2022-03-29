namespace Maelstrom.Services.DialogService
{
    internal class DialogService : IDialogService
    {
        public T OpenDialog<T>(DialogViewModel<T> vm)
        {
            IDialogWindow window = new DialogWindow();
            window.DataContext = vm;
            window.ShowDialog();
            return vm.DialogResult;
        }
    }
}
