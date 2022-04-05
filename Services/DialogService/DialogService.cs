namespace Maelstrom.Services.DialogService
{
    internal class DialogService : IDialogService
    {
        public void OpenDialog(DialogViewModel vm)
        {
            IDialogWindow window = new DialogWindow();
            window.DataContext = vm;
            window.ShowDialog();
        }
    }
}
