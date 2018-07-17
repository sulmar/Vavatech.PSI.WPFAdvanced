using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace Vavatech.PSI.WPF.Common.Behaviors
{

    // PM> Install-Package System.Windows.Interactivity.WPF
    public class ButtonBehavior : Behavior<Button>
    {

        public object Content { get; set; }

        // public double Width { get; set; }


        public double Width
        {
            get { return (double)GetValue(WidthProperty); }
            set { SetValue(WidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Width.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WidthProperty =
            DependencyProperty.Register("Width", typeof(double), typeof(ButtonBehavior), 
                new PropertyMetadata(100d, new PropertyChangedCallback(OnWidthPropertyChanged)));

        private static void OnWidthPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ButtonBehavior behavior = d as ButtonBehavior;

            if (behavior.AssociatedObject != null)
            {
                behavior.AssociatedObject.Width = (double)e.NewValue;
            }
        }

        protected override void OnAttached()
        {
            AssociatedObject.MouseEnter += AssociatedObject_MouseEnter;

            base.OnAttached();
        }

        private void AssociatedObject_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            AssociatedObject.Width = this.Width;
            AssociatedObject.Content = this.Content;
        }
    }
}
