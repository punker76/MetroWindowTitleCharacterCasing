using System.Windows;
using MahApps.Metro.Controls;

namespace MetroWindowTitleCharacterCasing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WrongWindowBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var wrongWindow = new WrongWindow
            {
                Owner = this,
            };
            wrongWindow.ShowDialog();
        }
        
        private void CorrectWindowBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var correctWindow = new MetroWindow()
            {
                Owner = this,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Title = "Correct Window",
                Width = 400, Height = 300
            };
            correctWindow.ShowDialog();
        }
    }
}
