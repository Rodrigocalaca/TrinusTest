using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace TrinusTest.Converters
{
    public class CpfConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;
            //retrieve only numbers in case we are dealing with already formatted phone no
            string phoneNo = value.ToString()!.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty).Replace(" ", string.Empty);
            phoneNo = Regex.Match(phoneNo, @"\d+").Value;

            switch (phoneNo.Length)
            {
                case 4:
                    return Regex.Replace(phoneNo, @"(\d{3})(\d{1})", "$1.$2");
                case 5:
                    return Regex.Replace(phoneNo, @"(\d{3})(\d{2})", "$1.$2");
                case 6:
                    return Regex.Replace(phoneNo, @"(\d{3})(\d{3})", "$1.$2");
                case 7:
                    return Regex.Replace(phoneNo, @"(\d{3})(\d{3})(\d{1})", "$1.$2.$3");
                case 8:
                    return Regex.Replace(phoneNo, @"(\d{3})(\d{3})(\d{2})", "$1.$2.$3");
                case 9:
                    return Regex.Replace(phoneNo, @"(\d{3})(\d{3})(\d{3})", "$1.$2.$3");
                case 10:
                    return Regex.Replace(phoneNo, @"(\d{3})(\d{3})(\d{3})(\d{1})", "$1.$2.$3-$4");
                case 11:
                    return Regex.Replace(phoneNo, @"(\d{3})(\d{3})(\d{3})(\d{2})", "$1.$2.$3-$4");
                default:
                    return phoneNo;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;
            //retrieve only numbers in case we are dealing with already formatted phone no
            string phoneNo = value.ToString()!.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty).Replace(" ", string.Empty);
            phoneNo = Regex.Match(phoneNo, @"\d+").Value;

            switch (phoneNo.Length)
            {
                case 4:
                    return Regex.Replace(phoneNo, @"(\d{3})(\d{1})", "$1.$2");
                case 5:
                    return Regex.Replace(phoneNo, @"(\d{3})(\d{2})", "$1.$2");
                case 6:
                    return Regex.Replace(phoneNo, @"(\d{3})(\d{3})", "$1.$2");
                case 7:
                    return Regex.Replace(phoneNo, @"(\d{3})(\d{3})(\d{1})", "$1.$2.$3");
                case 8:
                    return Regex.Replace(phoneNo, @"(\d{3})(\d{3})(\d{2})", "$1.$2.$3");
                case 9:
                    return Regex.Replace(phoneNo, @"(\d{3})(\d{3})(\d{3})", "$1.$2.$3");
                case 10:
                    return Regex.Replace(phoneNo, @"(\d{3})(\d{3})(\d{3})(\d{1})", "$1.$2.$3-$4");
                case 11:
                    return Regex.Replace(phoneNo, @"(\d{3})(\d{3})(\d{3})(\d{2})", "$1.$2.$3-$4");
                default:
                    return phoneNo;
            }
        }
    }
}
