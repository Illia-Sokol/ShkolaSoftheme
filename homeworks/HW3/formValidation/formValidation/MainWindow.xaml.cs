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

namespace formValidation
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

        public void ValidateForm(object sender, EventArgs e)
        {
            bool firstName = FirstName.Text.Length < 255 && FirstName.Text.All(Char.IsLetter);
            bool lastName = LastName.Text.Length < 255 && FirstName.Text.All(Char.IsLetter);
            bool gender = Male.IsChecked == true || Female.IsChecked == true;
            bool email = Email.Text.Contains('@') == true && Email.Text.Length < 255 ;
            bool phoneNumber = PhoneNumber.Text.All(Char.IsDigit) && PhoneNumber.Text.Length == 12;
            bool additionalInfo = AdditionalInfo.Text.Length < 2000;

            if(firstName && lastName && gender && email && phoneNumber && additionalInfo)
            {
                MessageBox.Show("Yep!!!");
            }
        }
    }
}
