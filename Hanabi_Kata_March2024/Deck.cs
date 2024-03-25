





namespace Hanabi_Kata_March2024
{
    internal class Deck
    {
        List<Card> cardsInDeck = new List<Card>();
        public Deck()
        {
            for (int i = 0; i < 3; i++)
            {
                cardsInDeck.Add(new Card(1, CardColors.RED));
                cardsInDeck.Add(new Card(1, CardColors.BLUE));
                cardsInDeck.Add(new Card(1, CardColors.WHITE));
                cardsInDeck.Add(new Card(1, CardColors.GREEN));
                cardsInDeck.Add(new Card(1, CardColors.YELLOW));
            }
            for (int cardNumber = 2; cardNumber < 5; cardNumber++)
            {
                for (int i = 0; i < 2; i++)
                {
                    cardsInDeck.Add(new Card(cardNumber, CardColors.RED));
                    cardsInDeck.Add(new Card(cardNumber, CardColors.BLUE));
                    cardsInDeck.Add(new Card(cardNumber, CardColors.WHITE));
                    cardsInDeck.Add(new Card(cardNumber, CardColors.GREEN));
                    cardsInDeck.Add(new Card(cardNumber, CardColors.YELLOW));
                }
            }

            cardsInDeck.Add(new Card(5, CardColors.RED));
            cardsInDeck.Add(new Card(5, CardColors.BLUE));
            cardsInDeck.Add(new Card(5, CardColors.WHITE));
            cardsInDeck.Add(new Card(5, CardColors.GREEN));
            cardsInDeck.Add(new Card(5, CardColors.YELLOW));
        }

        internal int Count()
        {
            return cardsInDeck.Count();
        }

        internal int CountCardsOfColorAndValue(CardColors coloc, int value)
        {
            int numberOfCards = cardsInDeck.Where(c => c.color == coloc && c.value == value).Count();
            return numberOfCards;
        }

        internal void DistributeCard()
        {
            cardsInDeck.RemoveAt(0);
        }
    }
}