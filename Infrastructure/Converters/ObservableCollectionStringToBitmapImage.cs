using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Media.Imaging;

namespace Maelstrom.Infrastructure.Converters
{
    internal class ObservableCollectionStringToBitmapImage : MultiValueConverter
    {
        public override object Convert(object[] v, Type t, object p, CultureInfo c)
        {
            var value1 = (ObservableCollection<string>)v[0];
            var value2 = (int)v[1];

            return new BitmapImage(new Uri("pack://application:,,," + value1[value2]));
        }
        public override object[] ConvertBack(object v, Type[] t, object p, CultureInfo c) => throw new NotImplementedException("Not Implemented yet");
    }
}
