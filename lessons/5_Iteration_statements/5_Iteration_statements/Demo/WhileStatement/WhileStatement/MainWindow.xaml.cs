using System.ComponentModel;
using System.Windows;
using Microsoft.Win32;
using System.IO;

namespace WhileStatement
{
    public partial class MainWindow
    {
        private readonly OpenFileDialog _openFileDialog;

        public MainWindow()
        {
            InitializeComponent();
            _openFileDialog = new OpenFileDialog();
            _openFileDialog.FileOk += OpenFileDialogFileOk;
        }

        private void OpenFileClick(object sender, RoutedEventArgs e)
        {
            _openFileDialog.ShowDialog();
        }

        private void OpenFileDialogFileOk(object sender, CancelEventArgs e)
        {
            var fullPathname = _openFileDialog.FileName;
            var src = new FileInfo(fullPathname);

            fileName.Text = src.FullName;
            TextReader reader = src.OpenText();

            DisplayData(reader);
        }

        private void DisplayData(TextReader reader)
        {
            source.Text = "";
            var line = reader.ReadLine();

            while (line != null)
            {
                source.Text += line + '\n';
                line = reader.ReadLine();
            }

            reader.Close();
        }
    }
}