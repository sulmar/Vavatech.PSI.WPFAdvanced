﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vavatech.PSI.WPF.Views
{
    /// <summary>
    /// Interaction logic for KeyboardView.xaml
    /// </summary>
    public partial class KeyboardView : UserControl
    {
        public KeyboardView()
        {
            InitializeComponent();
        }

        private void UniformGrid_Click(object sender, RoutedEventArgs e)
        {
            Button button = e.OriginalSource as Button;

            if (button != null)
            {
                MessageBox.Show($"Selected {button.Content} number!");
            }

            e.Handled = true;
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Grid_Click!");
        }
    }
}
