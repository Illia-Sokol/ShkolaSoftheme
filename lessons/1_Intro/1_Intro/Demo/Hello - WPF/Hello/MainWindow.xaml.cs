using System.Windows;
using ClassLibrary1;

namespace Hello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
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
            MessageBox.Show("Hello " + userName.Text);
        }
    }
}
