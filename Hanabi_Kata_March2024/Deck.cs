





namespace Hanabi_Kata_March2024
{
    internal class Deck
    {
        private List<Card> _cardsInDeck = new List<Card>();
        private const int NUMBER_OF_1_CARDS = 3;
        private const int NUMBER_OF_2_3_4_CARDS = 2;
        private const int CARD_OF_VALUE_2 = 2;
        private const int CARD_OF_VALUE_4 = 4;

        //TODO : should the factory pattern be used ? Knowing that the deck needs to be randomized : note the deck is not shuffled in the current implementation but the distribution is randomized
        public Deck()
        {
            for (int i = 0; i < NUMBER_OF_1_CARDS; i++)
            {
                _cardsInDeck.AddRange(new List<Card>
                {
                    new Card(1, CardColors.RED),
                    new Card(1, CardColors.BLUE),
                    new Card(1, CardColors.WHITE),
                    new Card(1, CardColors.GREEN),
                    new Card(1, CardColors.YELLOW)
                });
            }

            for (int cardNumber = CARD_OF_VALUE_2; cardNumber <= CARD_OF_VALUE_4; cardNumber++)
            {
                for (int i = 0; i < NUMBER_OF_2_3_4_CARDS; i++)
                {
                    _cardsInDeck.AddRange(new List<Card>
                    {
                        new Card(cardNumber, CardColors.RED),
                        new Card(cardNumber, CardColors.BLUE),
                        new Card(cardNumber, CardColors.WHITE),
                        new Card(cardNumber, CardColors.GREEN),
                        new Card(cardNumber, CardColors.YELLOW)
                    });
                }
            }
        
            _cardsInDeck.AddRange(new List<Card>
            {
                new Card(5, CardColors.RED),
                new Card(5, CardColors.BLUE),
                new Card(5, CardColors.WHITE),
                new Card(5, CardColors.GREEN),
                new Card(5, CardColors.YELLOW)
            });
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