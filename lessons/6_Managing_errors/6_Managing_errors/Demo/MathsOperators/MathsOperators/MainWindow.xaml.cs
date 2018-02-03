using System;
using System.Globalization;
using System.Windows;

namespace MathsOperators
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Сalculate(object sender, RoutedEventArgs e)
        {
            try
            {
                CalculateInternal();
            }
            catch (MySpecializedException exception)
            {
                result.Text = exception.Message;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CalculateInternal()
        {
            try
            {
                if (addition.IsChecked.GetValueOrDefault())
                {
                    AddValues();
                }
                else if (subtraction.IsChecked.GetValueOrDefault())
                {
                    SubtractValues();
                }
                else if (multiplication.IsChecked.GetValueOrDefault())
                {
                    MultiplyValues();
                }
                else if (division.IsChecked.GetValueOrDefault())
                {
                    DivideValues();
                }
                else if (remainder.IsChecked.GetValueOrDefault())
                {
                    RemainderValues();
                }
                else
                {
                    throw new InvalidOperationException("No operator selected");
                }
            }
            catch (FormatException formatException)
            {
                result.Text = formatException.Message;
            }
            catch (StackOverflowException overflowException)
            {
                result.Text = overflowException.Message;
            }
            catch (InvalidOperationException invalidOperationException)
            {
                result.Text = invalidOperationException.Message;
            }
            catch (DivideByZeroException divideByZeroException)
            {
                throw new MySpecializedException("Math operation failed", divideByZeroException);
            }
            catch (Exception ex)
            {
                result.Text = ex.Message;
            }
        }

        private void AddValues()
        {
            var leftOperand = int.Parse(lhsOperand.Text);
            var rightOperand = int.Parse(rhsOperand.Text);
            var outcome = leftOperand + rightOperand;

            expression.Text = lhsOperand.Text + " + " + rhsOperand.Text;
            result.Text = outcome.ToString();
        }

        private void SubtractValues()
        {
            var leftOperand = int.Parse(lhsOperand.Text);
            var rightOperand = int.Parse(rhsOperand.Text);
            var outcome = leftOperand - rightOperand;

            expression.Text = lhsOperand.Text + " - " + rhsOperand.Text;
            result.Text = outcome.ToString();
        }

        private void MultiplyValues()
        {
            var leftOperand = int.Parse(lhsOperand.Text);
            var rightOperand = int.Parse(rhsOperand.Text);
            var outcome = checked(leftOperand * rightOperand);

            expression.Text = lhsOperand.Text + " * " + rhsOperand.Text;
            result.Text = outcome.ToString();
        }

        private void DivideValues()
        {
            var leftOperand = int.Parse(lhsOperand.Text);
            var rightOperand = int.Parse(rhsOperand.Text);
            var outcome = leftOperand / rightOperand;

            expression.Text = lhsOperand.Text + " / " + rhsOperand.Text;
            result.Text = outcome.ToString();
        }

        private void RemainderValues()
        {
            var leftOperand = int.Parse(lhsOperand.Text);
            var rightOperand = int.Parse(rhsOperand.Text);
            var outcome = leftOperand % rightOperand;

            expression.Text = lhsOperand.Text + " % " + rhsOperand.Text;
            result.Text = outcome.ToString();
        }

        private void OnQuitClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }

    public class MySpecializedException : Exception
    {
        public MySpecializedException(string errorMessage, Exception innerException)
            : base(errorMessage, innerException)
        {
        }

        public MySpecializedException()
            : base("Hello world")
        {
        }
    }
}
