using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFConverters_MVVM
{
    public class EnumToFontSizeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                if (((TextSize)value).Equals(TextSize.Small)) return 12;
                else if (((TextSize)value).Equals(TextSize.Medium)) return 24;
                else if (((TextSize)value).Equals(TextSize.Big)) return 48;
                return 12;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
