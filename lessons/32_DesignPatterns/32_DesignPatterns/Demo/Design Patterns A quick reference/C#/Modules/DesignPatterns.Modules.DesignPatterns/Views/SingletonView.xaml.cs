using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DesignPatterns.Modules.ViewModels;

namespace DesignPatterns.Modules.Views
{
    /// <summary>
    /// Interaction logic for SingletonView.xaml
    /// </summary>
    public partial class SingletonView : UserControl
    {
        public SingletonView(SingletonViewModel model)
        {
            InitializeComponent();
            DataContext = model;
        }
    }
}
