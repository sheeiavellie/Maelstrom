using Maelstrom.Models.Objects.GameObjects;
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Media.Imaging;

namespace Maelstrom.Infrastructure.Converters
{
    internal class ObservableCollectionItemByAlternationIndex : MultiValueConverter
    {
        public override object Convert(object[] v, Type t, object p, CultureInfo c)
        {
            var value1 = (ObservableCollection<string>)v[0];
            var value2 = (ObservableCollection<GameObject>)v[1];
            var value3 = (int)v[2];

            foreach(var tex in value1)
            {
                if ("/Maelstrom;component//Data/Resources/Textures/" + value2[value3].GetType().Name + ".png" == tex)
                {
                    return new BitmapImage(new Uri("pack://application:,,," + tex));
                }
            }

            return new BitmapImage(new Uri("pack://application:,,," + value1[0]));
        }
        public override object[] ConvertBack(object v, Type[] t, object p, CultureInfo c) => throw new NotImplementedException("Not Implemented yet");
    }
}
