using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Vavatech.PSI.WPF.Common.AttachedProperties
{
    [ContentProperty("Content")]
    public class TextBoxEx : TextBox
    {
        public object Content
        {
            get { return (object)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Content.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(object), typeof(TextBoxEx), new PropertyMetadata(null, OnPropertyChanged));

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TextBoxEx textbox = d as TextBoxEx;

            textbox.Text = e.NewValue.ToString();
        }
    }


    public class Ex : DependencyObject
    {

        public static object GetContent(TextBox obj)
        {
            return (object)obj.GetValue(ContentProperty);
        }

        public static void SetContent(TextBox obj, object value)
        {
            obj.SetValue(ContentProperty, value);
        }

        // Using a DependencyProperty as the backing store for Content.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.RegisterAttached("Content", typeof(object), typeof(Ex), new PropertyMetadata(null, OnPropertChanged));

        private static void OnPropertChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TextBox textbox = d as TextBox;

            textbox.MouseEnter -= Textbox_MouseEnter;

            textbox.Text = e.NewValue.ToString();

            textbox.MouseEnter += Textbox_MouseEnter;
        }

        private static void Textbox_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            textBox.Width = 200;
        }
    }
}
