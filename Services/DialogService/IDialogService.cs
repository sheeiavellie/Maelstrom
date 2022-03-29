namespace Maelstrom.Services.DialogService
{
    internal interface IDialogService
    {
        T OpenDialog<T>(DialogViewModel<T> vm);
    }
}
