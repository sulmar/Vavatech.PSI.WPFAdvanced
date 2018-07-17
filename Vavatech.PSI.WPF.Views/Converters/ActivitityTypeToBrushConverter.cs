using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Vavatech.PSI.WPF.Common.Converters;
using Vavatech.PSI.WPF.Models;

namespace Vavatech.PSI.WPF.Views.Converters
{
    public class ActivitityTypeToBrushConverter : BaseValueConverter<ActivitityTypeToBrushConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ActivityType activityType = (ActivityType)value;

            switch(activityType)
            {
                case ActivityType.Rest: return Brushes.Green;
                case ActivityType.Working: return Brushes.Red;
                case ActivityType.Delegated: return Brushes.Blue;
            }

            throw new ArgumentOutOfRangeException();
        }
    }
}
