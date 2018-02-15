using System;
using System.Linq;
using System.Windows;

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
            short currentYear = 2018;
            bool firstName = FirstName.Text.Length < 255 && FirstName.Text.All(Char.IsLetter);
            bool lastName = LastName.Text.Length < 255 && LastName.Text.All(Char.IsLetter);
            bool gender = Male.IsChecked == true || Female.IsChecked == true;
            bool birthDate = checkBirthDate(BirthDate.Text, currentYear);
            bool email = Email.Text.Contains('@') && Email.Text.Length < 255 ;
            bool phoneNumber = PhoneNumber.Text.All(Char.IsDigit) && PhoneNumber.Text.Length == 12;
            bool additionalInfo = AdditionalInfo.Text.Length < 2000;

            if (firstName && lastName && gender && email && phoneNumber && additionalInfo && birthDate)
            {
                MessageBox.Show("Form is valid");
            } else
            {
                MessageBox.Show("Form is invalid, something wrong");
            }
        }

        private bool checkBirthDate(string birthDate, int currentYear)
        {
            if (!(birthDate.Length == 10))
            {
                return false;
            }
            string day = birthDate.Substring(0, 2);
            string month = birthDate.Substring(3, 2);
            string year = birthDate.Substring(6, 4);

            if ( !(day.All(Char.IsDigit) && month.All(Char.IsDigit) && year.All(Char.IsDigit)) )
            {
                return false;
            }
            bool isDay = Int16.Parse(day) > 0 && Int16.Parse(day) < 32;
            bool isMonth = Int16.Parse(month) > 0 && Int16.Parse(month) < 13;
            bool isYear = Int16.Parse(year) > 1900 && Int16.Parse(year) < currentYear;

            return isDay && isMonth && isYear ? true : false;
        }
    }
}
