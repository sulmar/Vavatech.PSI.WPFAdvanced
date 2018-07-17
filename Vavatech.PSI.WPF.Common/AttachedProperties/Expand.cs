using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Vavatech.PSI.WPF.Common.AttachedProperties
{
    public class Expand : DependencyObject
    {
        public static bool GetIsExpand(ComboBox obj)
        {
            return (bool)obj.GetValue(IsExpandProperty);
        }

        public static void SetIsExpand(ComboBox obj, bool value)
        {
            obj.SetValue(IsExpandProperty, value);
        }

        // Using a DependencyProperty as the backing store for IsExpand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsExpandProperty =
            DependencyProperty.RegisterAttached("IsExpand", typeof(bool), typeof(Expand), 
                new PropertyMetadata(false, OnPropertyChanged));

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ComboBox comboBox = d as ComboBox;

            comboBox.MouseEnter -= ComboBox_MouseEnter;
            comboBox.MouseEnter += ComboBox_MouseEnter;
            
        }

        private static void ComboBox_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            comboBox.IsDropDownOpen = GetIsExpand(comboBox);


        }
    }
}
