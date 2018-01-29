
using System.Windows;
using ConsoleApplication1;

namespace WPF_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var myNewClass = new Class1();
        }

        private void OkClick(object sender, RoutedEventArgs e)
          {
            MessageBox.Show("HEllo " + userName.text);
          }
    }
}
