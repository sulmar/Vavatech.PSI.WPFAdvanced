using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Vavatech.PSI.WPF.Common.Converters
{
    public class BoolToVisibilityConverter : BaseValueConverter<BoolToVisibilityConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool bValue = (bool)value;

            return bValue ? Visibility.Visible : Visibility.Hidden;
        }
    }
}
