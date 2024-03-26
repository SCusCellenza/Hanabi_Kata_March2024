





namespace Hanabi_Kata_March2024
{
    internal class Deck
    {
        private List<Card> _cardsInDeck = new List<Card>();
        private const int NUMBER_OF_1_CARDS = 3;
        private const int NUMBER_OF_2_3_4_CARDS = 2;

        //TODO : should the factory pattern be used ? Knowing that the deck needs to be randomized : note the deck is not shuffled in the current implementation but the distribution is randomized
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
            if (_cardsInDeck.Count() == 0)
                { throw new Exception("Deck is empty, you are not allowed to pick a card"); }

            int randomNumber = new Random().Next(0, _cardsInDeck.Count);

            Card card = _cardsInDeck[randomNumber];
            _cardsInDeck.RemoveAt(randomNumber);
            return card;
        }
    }
}