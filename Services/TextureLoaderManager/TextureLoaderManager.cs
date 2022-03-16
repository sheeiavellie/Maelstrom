namespace Maelstrom.Services.TextureLoaderManager
{
    internal class TextureLoaderManager : ITextureLoaderManager
    {
        public string LoadTexture(string Filename) => string.Format("/Maelstrom;component/Data/Resources/Textures/{0}", Filename) ?? "/Maelstrom;component/Data/Resources/Textures/error.png";
    }
}
