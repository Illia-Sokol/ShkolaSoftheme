using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppMinMaxTypeValue
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBoxTypeSelection(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (ListBoxItem)listTypes.SelectedItem;

            switch (selectedItem.Content.ToString())
            {
                case "byte":
                    showByteValue();
                    break;
                case "sbyte":
                    showSbyteValue();
                    break;
                case "short":
                    showShortValue();
                    break;
                case "int":
                    showIntValue();
                    break;
                case "long":
                    showLongValue();
                    break;
                case "float":
                    showFloatValue();
                    break;
                case "double":
                    showDoubleValue();
                    break;
                case "decimal":
                    showDecimalValue();
                    break;
                case "ulong":
                    showUlongValue();
                    break;
                case "ushort":
                    showUshortValue();
                    break;
                case "uint":
                    showUintValue();
                    break;
                default:
                    break;
            }
        }

        private void showByteValue()
        {
            minValue.Text = byte.MinValue.ToString(CultureInfo.InvariantCulture);
            maxValue.Text = byte.MaxValue.ToString(CultureInfo.InvariantCulture);
            defaultValue.Text = default(byte).ToString(CultureInfo.InvariantCulture);
        }

        private void showSbyteValue()
        {
            minValue.Text = sbyte.MinValue.ToString(CultureInfo.InvariantCulture);
            maxValue.Text = sbyte.MaxValue.ToString(CultureInfo.InvariantCulture);
            defaultValue.Text = default(sbyte).ToString(CultureInfo.InvariantCulture);
        }

        private void showShortValue()
        {
            minValue.Text = short.MinValue.ToString(CultureInfo.InvariantCulture);
            maxValue.Text = short.MaxValue.ToString(CultureInfo.InvariantCulture);
            defaultValue.Text = default(short).ToString(CultureInfo.InvariantCulture);
        }

        private void showIntValue()
        {
            minValue.Text = int.MinValue.ToString(CultureInfo.InvariantCulture);
            maxValue.Text = int.MaxValue.ToString(CultureInfo.InvariantCulture);
            defaultValue.Text = default(int).ToString(CultureInfo.InvariantCulture);
        }

        private void showLongValue()
        {
            minValue.Text = long.MinValue.ToString(CultureInfo.InvariantCulture);
            maxValue.Text = long.MaxValue.ToString(CultureInfo.InvariantCulture);
            defaultValue.Text = default(long).ToString(CultureInfo.InvariantCulture);
        }

        private void showFloatValue()
        {
            minValue.Text = float.MinValue.ToString(CultureInfo.InvariantCulture);
            maxValue.Text = float.MaxValue.ToString(CultureInfo.InvariantCulture);
            defaultValue.Text = default(float).ToString(CultureInfo.InvariantCulture);
        }

        private void showDoubleValue()
        {
            minValue.Text = double.MinValue.ToString(CultureInfo.InvariantCulture);
            maxValue.Text = double.MaxValue.ToString(CultureInfo.InvariantCulture);
            defaultValue.Text = default(double).ToString(CultureInfo.InvariantCulture);
        }

        private void showDecimalValue()
        {
            minValue.Text = decimal.MinValue.ToString(CultureInfo.InvariantCulture);
            maxValue.Text = decimal.MaxValue.ToString(CultureInfo.InvariantCulture);
            defaultValue.Text = default(decimal).ToString(CultureInfo.InvariantCulture);
        }

        private void showUlongValue()
        {
            minValue.Text = ulong.MinValue.ToString(CultureInfo.InvariantCulture);
            maxValue.Text = ulong.MaxValue.ToString(CultureInfo.InvariantCulture);
            defaultValue.Text = default(ulong).ToString(CultureInfo.InvariantCulture);
        }

        private void showUshortValue()
        {
            minValue.Text = ushort.MinValue.ToString(CultureInfo.InvariantCulture);
            maxValue.Text = ushort.MaxValue.ToString(CultureInfo.InvariantCulture);
            defaultValue.Text = default(ushort).ToString(CultureInfo.InvariantCulture);
        }

        private void showUintValue()
        {
            minValue.Text = uint.MinValue.ToString(CultureInfo.InvariantCulture);
            maxValue.Text = uint.MaxValue.ToString(CultureInfo.InvariantCulture);
            defaultValue.Text = default(uint).ToString(CultureInfo.InvariantCulture);
        }

        private void closeWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
