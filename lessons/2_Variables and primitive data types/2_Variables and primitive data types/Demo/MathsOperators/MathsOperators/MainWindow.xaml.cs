using System;
using System.Windows;

namespace MathsOperators
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

        private void CalculateClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (addition.IsChecked.HasValue && addition.IsChecked.Value)
                {
                    AddValues();
                }
                else if (subtraction.IsChecked.HasValue && subtraction.IsChecked.Value)
                {
                    SubtractValues();
                }
                else if (multiplication.IsChecked.HasValue && multiplication.IsChecked.Value)
                {
                    MultiplyValues();
                }
                else if (division.IsChecked.HasValue && division.IsChecked.Value)
                {
                    DivideValues();
                }
                else if (remainder.IsChecked.HasValue && remainder.IsChecked.Value)
                {
                    RemainderValues();
                }
            }
            catch (Exception caught)
            {
                expression.Text = "";
                result.Text = caught.Message;
            }
        }

        private void AddValues()
        {
            int leftOperand= int.Parse(lhsOperand.Text);
            int rightOperand= int.Parse(rhsOperand.Text);
            int outcome = 0;
            
            outcome = leftOperand + rightOperand;
            expression.Text = lhsOperand.Text + " + " + rhsOperand.Text;
            result.Text = outcome.ToString();
        }

        private void SubtractValues()
        {
            int leftOperand= int.Parse(lhsOperand.Text);
            int rightOperand= int.Parse(rhsOperand.Text);
            int outcome = 0;

            outcome = leftOperand - rightOperand;
            expression.Text = lhsOperand.Text + " - " + rhsOperand.Text;
            result.Text = outcome.ToString();
        }

        private void MultiplyValues()
        {
            int leftOperand= int.Parse(lhsOperand.Text);
            int rightOperand= int.Parse(rhsOperand.Text);
            int outcome = 0;

            outcome = leftOperand * rightOperand;
            expression.Text = lhsOperand.Text + " * " + rhsOperand.Text;
            result.Text = outcome.ToString();
        }

        private void DivideValues()
        {
            int leftOperand= int.Parse(lhsOperand.Text);
            int rightOperand= int.Parse(rhsOperand.Text);
            int outcome = 0;

            outcome = leftOperand / rightOperand;
            expression.Text = lhsOperand.Text + " / " + rhsOperand.Text;
            result.Text = outcome.ToString();
        }

        private void RemainderValues()
        {
            int leftOperand= int.Parse(lhsOperand.Text);
            int rightOperand= int.Parse(rhsOperand.Text);
            int outcome = 0;

            outcome = leftOperand % rightOperand;
            expression.Text = lhsOperand.Text + " % " + rhsOperand.Text;
            result.Text = outcome.ToString();
        }

        private void QuitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
