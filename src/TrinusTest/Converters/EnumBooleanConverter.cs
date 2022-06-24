using System;
using System.Windows.Data;
using System.Globalization;
namespace TrinusTest.Converters
{
    public class EnumBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return false;
            return value.Equals(parameter);
        }
        public object? ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;
            return value.Equals(true) ? parameter : Binding.DoNothing;
        }

    }
}