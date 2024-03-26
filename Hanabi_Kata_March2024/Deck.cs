





namespace Hanabi_Kata_March2024
{
    internal class Deck
    {
        private List<Card> _cardsInDeck = new List<Card>();
        private const int NUMBER_OF_1_CARDS = 3;
        private const int NUMBER_OF_2_3_4_CARDS = 2;
        public Deck()
        {
            for (int i = 0; i < NUMBER_OF_1_CARDS; i++)
            {
                _cardsInDeck.Add(new Card(1, CardColors.RED));
                _cardsInDeck.Add(new Card(1, CardColors.BLUE));
                _cardsInDeck.Add(new Card(1, CardColors.WHITE));
                _cardsInDeck.Add(new Card(1, CardColors.GREEN));
                _cardsInDeck.Add(new Card(1, CardColors.YELLOW));
            }

            for (int cardNumber = 2; cardNumber < 5; cardNumber++)
            {
                for (int i = 0; i < NUMBER_OF_2_3_4_CARDS; i++)
                {
                    _cardsInDeck.Add(new Card(cardNumber, CardColors.RED));
                    _cardsInDeck.Add(new Card(cardNumber, CardColors.BLUE));
                    _cardsInDeck.Add(new Card(cardNumber, CardColors.WHITE));
                    _cardsInDeck.Add(new Card(cardNumber, CardColors.GREEN));
                    _cardsInDeck.Add(new Card(cardNumber, CardColors.YELLOW));
                }
            }

            _cardsInDeck.Add(new Card(5, CardColors.RED));
            _cardsInDeck.Add(new Card(5, CardColors.BLUE));
            _cardsInDeck.Add(new Card(5, CardColors.WHITE));
            _cardsInDeck.Add(new Card(5, CardColors.GREEN));
            _cardsInDeck.Add(new Card(5, CardColors.YELLOW));
        }

        internal int Count()
        {
            return _cardsInDeck.Count();
        }

        internal int CountCardsOfColorAndValue(CardColors coloc, int value)
        {
            int numberOfCards = _cardsInDeck.Where(c => c.color == coloc && c.value == value).Count();
            return numberOfCards;
        }

        internal Card DistributeCard()
        {
            Card card = _cardsInDeck[0];
            _cardsInDeck.RemoveAt(0);
            return card;
        }
    }
}