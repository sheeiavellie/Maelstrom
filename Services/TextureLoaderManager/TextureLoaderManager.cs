using System;
using System.IO;
using Maelstrom.Data.Resources.Constants;

namespace Maelstrom.Services.TextureLoaderManager
{
    internal class TextureLoaderManager : ITextureLoaderManager
    {
        public string LoadTexture(string Filename)
        {
            if (File.Exists(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + ConstantPath.Textures + Filename))
            {
                return ConstantPath.URI + ConstantPath.Textures + Filename;
            }

            return ConstantPath.URI + ConstantPath.Textures + "error.png";
        }
    }
}
