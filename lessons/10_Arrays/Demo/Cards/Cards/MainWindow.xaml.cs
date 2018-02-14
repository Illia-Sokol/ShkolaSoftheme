using System;
using System.Windows;

namespace Cards
{
    public partial class MainWindow
    {
        public const int NumHands = 4;
        private Pack _pack;
        private readonly Hand[] _hands = new Hand[NumHands];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DealClick(object sender, RoutedEventArgs e)
        {
            try
            {
                _pack = new Pack();

                for (var handNum = 0; handNum < NumHands; handNum++)
                {
                    _hands[handNum] = new Hand();
                    for (var numCards = 0; numCards < Hand.HandSize; numCards++)
                    {
                        var cardDealt = _pack.DealCardFromPack();
                        _hands[handNum].AddCardToHand(cardDealt);
                    }
                }

                north.Text = _hands[0].ToString();
                south.Text = _hands[1].ToString();
                east.Text = _hands[2].ToString();
                west.Text = _hands[3].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
