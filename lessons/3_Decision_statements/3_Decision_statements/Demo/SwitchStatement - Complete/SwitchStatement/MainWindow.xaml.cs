using System.Windows;


namespace SwitchStatement
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CopyClick(object sender, RoutedEventArgs e)
        {
            target.Text = "";
            var from = source.Text;
            for (var i = 0; i != from.Length; i++)
            {
                var current = from[i];
                CopyOne(current);
            }
        }

        private void CopyOne(char current)
        {
            switch (current)
            {
                case '<':
                    target.Text += "&lt;";
                    break;
                case '>':
                    target.Text += "&gt;";
                    break;
                case '&':
                    target.Text += "&amp;";
                    break;
                case '\"':
                    target.Text += "&#34;";
                    break;
                case '\'':
                    target.Text += "&#39;";
                    break;
                default:
                    target.Text += current;
                    break;
            }
        }
    }
}