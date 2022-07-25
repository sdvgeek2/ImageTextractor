using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Input;
using ImageTextractor.Controller;
using ImageTextractor.Model;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace ImageTextractor
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    OpenFileDialog dialog = new OpenFileDialog();

    public MainWindow()
    {
        InitializeComponent();
    }

    private void OpenImage_Click(object sender, RoutedEventArgs e)
    {
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

    private void ChosenImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      ImgTextractorController con = new ImgTextractorController(new ImgTextractor(dialog.FileName));

      con.GetText();     
    } 
  }
}
