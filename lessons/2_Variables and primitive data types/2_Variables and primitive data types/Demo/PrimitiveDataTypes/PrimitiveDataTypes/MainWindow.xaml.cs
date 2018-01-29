using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace PrimitiveDataTypes
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBoxTypeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (ListBoxItem)type.SelectedItem;

            switch (selectedItem.Content.ToString())
            {
                case "int":
                    ShowIntValue();
                    break;
                case "long":
                    ShowLongValue();
                    break;
                case "float":
                    ShowFloatValue();
                    break;
                case "double":
                    ShowDoubleValue();
                    break;
                case "decimal":
                    ShowDecimalValue();
                    break;
                case "string":
                    ShowStringValue();
                    break;
                case "char":
                    ShowCharValue();
                    break;
                case "bool":
                    ShowBoolValue();
                    break;
            }
        }

        private void ShowIntValue()
        {
            int intVar = 42;
            value.Text = intVar.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowLongValue()
        {
            long longVar = 42L;
            value.Text = longVar.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowFloatValue()
        {
            float floatVar = 0.42F;
            value.Text = floatVar.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowDoubleValue()
        {
            var doubleVar = 0.42;
            value.Text = doubleVar.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowDecimalValue()
        {
            decimal decimalVar = 0.42M;
            value.Text = decimalVar.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowStringValue()
        {
            string stringVar = "Hello world";
            value.Text = stringVar;
        }

        private void ShowCharValue()
        {
            char charVar = 'x';
            value.Text = charVar.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowBoolValue()
        {
            bool boolVar = false;
            value.Text = boolVar.ToString(CultureInfo.InvariantCulture);
        }

        private void QuitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
