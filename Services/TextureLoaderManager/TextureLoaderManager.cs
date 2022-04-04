using System;
using System.Collections.ObjectModel;
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
        public ObservableCollection<string> LoadAllTexturesWithPrefix(string Directoryname, string Prefix)
        {
            ObservableCollection<string> TexturesWithPrefix = new ObservableCollection<string>();

            foreach(var file in new DirectoryInfo(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + ConstantPath.Textures + Directoryname).GetFiles(Prefix + "*.png"))
            {
                TexturesWithPrefix.Add(ConstantPath.URI + ConstantPath.Textures + Directoryname + file.Name);
            }

            return TexturesWithPrefix;
        }
    }
}
