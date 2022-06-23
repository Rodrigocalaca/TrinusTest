using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace TrinusTest.Converters
{
    internal class CapitalNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value != null)
            {
                string? text = value as string;
                string result = "";
                bool capitalize = true;
                if(text != null)
                {
                    foreach (char c in text)
                    {
                        if (capitalize)
                        {
                            result += c.ToString().ToUpper();
                            capitalize = false;
                        }
                        else
                        {
                            result += c;
                        }
                        if (c == ' ')
                        {
                            capitalize = true;
                        }
                    }
                }               
                return result;
            }
            else
            {
                return string.Empty;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
