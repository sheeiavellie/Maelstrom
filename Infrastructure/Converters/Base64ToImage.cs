using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Maelstrom.Infrastructure.Converters
{
    internal class Base64ToImage : Converter
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string s = value as string;

            if (s == null)
                return null;

            BitmapImage bi = new BitmapImage();

            bi.BeginInit();
            bi.StreamSource = new MemoryStream(System.Convert.FromBase64String(s));
            bi.EndInit();

            return bi;
        }

        public override object ConvertBack(object v, Type t, object p, CultureInfo c) => throw new NotImplementedException("Not Implemented yet");
    }
}