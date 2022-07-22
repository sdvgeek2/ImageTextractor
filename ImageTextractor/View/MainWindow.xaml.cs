using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Input;

namespace ImageTextractor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;";

            if (dialog.ShowDialog() == true)
            {
                ChosenImage.Source = new BitmapImage(new Uri(dialog.FileName));
            }

            OpenImage.Visibility = Visibility.Hidden;
        }

        private void ChosenImage_MouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.IBeam;
        }

        // to do: select text, execute controller logic

        private void ChosenImage_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
        }
    }
}
