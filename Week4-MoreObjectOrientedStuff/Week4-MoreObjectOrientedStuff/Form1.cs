namespace Week4_MoreObjectOrientedStuff
{
    public partial class Form1 : Form
    {
        List<Card> cards;
        public Form1()
        {
            InitializeComponent();
            cards = new List<Card>();
        }

        private void getCardButton_Click(object sender, EventArgs e)
        {
            cards.Clear();
            for ( int cardNumber = 0; cardNumber < 5; cardNumber++)
            {
                Card card = new Card();
                cards.Add(card);
            }

            cardLabel.Text = "";

            //same as below - but you can modify the list by index
            //for (int index = 0; index < cards.Count; index++)
            //{
            //    // can still modify values by index
            //   // cards[index] = new Card();
            //    Card card = cards[index];
            //    cardLabel.Text += $"{card}{Environment.NewLine}";
            //}

            // enhanced for loop - the list is read only
            foreach ( Card card in cards)
            {
                //card = new Card();
                cardLabel.Text += $"{card}{Environment.NewLine}";
            }

            numericValueLabel.Text = $"{cards[0].GetNumericValues().faceValue} {cards[0].GetNumericValues().suitValue}";
            numericValueLabel.Text += $"{cards[0].OtherGetNumericValues().Item1} {cards[0].OtherGetNumericValues().Item2}";
            
            (int faceInt, int suitInt ) numbers = cards[0].OtherGetNumericValues();
            

            Hand hand = new Hand();
            handLabel.Text = $"{hand.GetStrings().Item1}" +
                $"{Environment.NewLine}" +
                $"{hand.GetStrings().Item2}";


        }
    }
}