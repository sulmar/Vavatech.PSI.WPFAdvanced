using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Vavatech.PSI.WPF.Views.CustomControls
{
    public class MyControl : Control
    {

        public MyControl()
        {
            // DefaultStyleKey = typeof(MyControl);

            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyControl), new FrameworkPropertyMetadata(typeof(MyControl)));

        }
    }
}
