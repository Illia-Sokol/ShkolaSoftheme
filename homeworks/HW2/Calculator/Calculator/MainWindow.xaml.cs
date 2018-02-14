using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
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

        private void calculateClick(object sender, RoutedEventArgs e)
        {
            if (multiplication.IsChecked.HasValue && multiplication.IsChecked.Value)
            {
                Multiplication();
            }
            else if (division.IsChecked.HasValue && division.IsChecked.Value)
            {
                Division();
            }
            else if (addition.IsChecked.HasValue && addition.IsChecked.Value)
            {
                Addition();
            }
            else if (subtraction.IsChecked.HasValue && subtraction.IsChecked.Value)
            {
                Subtraction();
            }
            else if (pow.IsChecked.HasValue && pow.IsChecked.Value)
            {
                Pow();
            }
            else if (remind.IsChecked.HasValue && remind.IsChecked.Value)
            {
                Remind();
            }
        }

        private void Multiplication()
        {
            double leftOperand = double.Parse(lfOperand.Text);
            double rightOperand = double.Parse(rghOperand.Text);
            double outcome = 0;

            outcome = leftOperand * rightOperand;
            expresion.Text = leftOperand + " * " + rightOperand;

            result.Text = outcome.ToString();
        }

        private void Division()
        {
            double leftOperand = double.Parse(lfOperand.Text);
            double rightOperand = double.Parse(rghOperand.Text);
            double outcome = 0;

            outcome =  Math.Floor( leftOperand / rightOperand * 100 ) / 100;
            expresion.Text = leftOperand + " / " + rightOperand;

            result.Text = outcome.ToString();
        }

        private void Addition()
        {
            double leftOperand = double.Parse(lfOperand.Text);
            double rightOperand = double.Parse(rghOperand.Text);
            double outcome = 0;

            outcome = leftOperand + rightOperand;
            expresion.Text = leftOperand + " + " + rightOperand;

            result.Text = outcome.ToString();
        }

        private void Subtraction()
        {
            double leftOperand = double.Parse(lfOperand.Text);
            double rightOperand = double.Parse(rghOperand.Text);
            double outcome = 0;

            outcome = leftOperand - rightOperand;
            expresion.Text = leftOperand + " - " + rightOperand;

            result.Text = outcome.ToString();
        }

        private void Pow()
        {
            double leftOperand = double.Parse(lfOperand.Text);
            double rightOperand = double.Parse(rghOperand.Text);
            double outcome = 0;

            outcome = Math.Pow(leftOperand, rightOperand);
            expresion.Text = leftOperand + " ^ " + rightOperand;

            result.Text = outcome.ToString();
        }

        private void Remind()
        {
            double leftOperand = double.Parse(lfOperand.Text);
            double rightOperand = double.Parse(rghOperand.Text);
            double outcome = 0;

            outcome = leftOperand % rightOperand;
            expresion.Text = leftOperand + " % " + rightOperand;

            result.Text = outcome.ToString();
        }
    }
}
