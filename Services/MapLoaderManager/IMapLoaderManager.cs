namespace Maelstrom.Services.MapLoaderManager
{
    internal interface IMapLoaderManager
    {
        string JsonMapFileIn { get; set; }
        dynamic ReadMapFromFile();
    }
}
