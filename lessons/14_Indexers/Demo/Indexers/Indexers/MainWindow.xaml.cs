using System;
using System.Windows;

namespace Indexers
{
    public partial class MainWindow
    {
        private readonly PhoneBook _phoneBook = new PhoneBook();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void FindByNameClick(object sender, RoutedEventArgs e)
        {
            var text = name.Text;
            if (!string.IsNullOrEmpty(text))
            {
                var personsName = new Name(text);
                var personsPhoneNumber = _phoneBook[personsName];
                phoneNumber.Text = string.IsNullOrEmpty(personsPhoneNumber.Text) ? "Not Found" : personsPhoneNumber.Text;
            }
        }

        private void FindByPhoneNumberClick(object sender, RoutedEventArgs e)
        {
            var text = phoneNumber.Text;
            if (!string.IsNullOrEmpty(text))
            {
                var personsPhoneNumber = new PhoneNumber(text);
                var personsName = _phoneBook[personsPhoneNumber];
                name.Text = string.IsNullOrEmpty(personsName.Text) ? "Not Found" : personsName.Text;
            }
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(name.Text) && !String.IsNullOrEmpty(phoneNumber.Text))
            {
                _phoneBook.Add(new Name(name.Text), new PhoneNumber(phoneNumber.Text));
                name.Text = "";
                phoneNumber.Text = "";
            }
        }
    }
}
