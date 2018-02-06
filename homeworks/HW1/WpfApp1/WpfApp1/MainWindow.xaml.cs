using System;
using System.Windows;


namespace WpfApp1
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

        private void ShowUserName(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("my name is " + userName.Text);
        }
    }
}
