using System;
using System.Globalization;
using System.Windows.Data;

namespace WPFConverters
{
    public class BooleanToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value? 8:3;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToInt32(value)<8 ? false: true ;
        }
    }
}
