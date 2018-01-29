using System;
using System.Windows;

namespace Selection
{
    /// <summary>
    /// Interaction logic for Window.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CompareClick(object sender, RoutedEventArgs e)
        {
            int diff = DateCompare(First, Second);
            info.Text = "";
            Show("firstDate == secondDate", diff == 0);
            Show("firstDate != secondDate", diff != 0);
            Show("firstDate <  secondDate", diff < 0);
            Show("firstDate <= secondDate", diff <= 0);
            Show("firstDate >  secondDate", diff > 0);
            Show("firstDate >= secondDate", diff >= 0);
        }

        private void Show(string exp, bool result)
        {
            info.Text += exp;
            info.Text += " : " + result;
            info.Text += "\n";
        }

        private int DateCompare(DateTime leftHandSide, DateTime rightHandSide)
        {
            int result; 
            
            if (leftHandSide.Year < rightHandSide.Year) 
            { 
                result = -1; 
            } 
            else if (leftHandSide.Year > rightHandSide.Year) 
            { 
                result = 1; 
            }
            else if (leftHandSide.Month < rightHandSide.Month) 
            { 
                result = -1; 
            } 
            else if (leftHandSide.Month > rightHandSide.Month) 
            { 
                result = 1; 
            }
            else if (leftHandSide.Day < rightHandSide.Day) 
            { 
                result = -1;
            }
            else if (leftHandSide.DayOfWeek > rightHandSide.DayOfWeek)
            {
                result = 1;
            }
            else
            {
                result = 0;
            }
            
            return result;
        }

        #region Conversion properties to cater for the deifferences betwwen the DatePicker control in Windows 7 and Windows 8.1
        private DateTime First
        {
            get { return firstDate.SelectedDate.GetValueOrDefault(firstDate.DisplayDate); }
        }

        private DateTime Second
        {
            get { return secondDate.SelectedDate.GetValueOrDefault(secondDate.DisplayDate); }
        }
        #endregion
    }
}
