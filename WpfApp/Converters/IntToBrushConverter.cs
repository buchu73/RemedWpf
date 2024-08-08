using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApp.Converters
{
    public class IntToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int valueAsInt = (int)value;

            if (valueAsInt < 0)
            {
                return new SolidColorBrush(Colors.Blue);
            }
            else if (valueAsInt < 10)
            {
                return new SolidColorBrush(Colors.Chartreuse);
            }
            else
            { 
                return new SolidColorBrush(Colors.Red); 
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
