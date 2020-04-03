using System;
using System.Globalization;
using Xamarin.Forms;

namespace Hardware.Converters
{
    public class DoubleNullableConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double? nullable = value as double?;
            if (nullable != null && nullable.Value != 0.0)
                return nullable.Value.ToString("0.0");

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
