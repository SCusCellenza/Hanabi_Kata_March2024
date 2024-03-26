


namespace Hanabi_Kata_March2024
{
    public class DeckTest
    {
        private const int NUMBER_OF_1_CARDS = 3;
        private const int NUMBER_OF_2_3_4_CARDS = 2;
        private const int NUMBER_OF_5_CARDS = 1;
        private const int NUMBER_OF_CARDS = 50;

        [Fact]
        public void DeckShouldBeFilledWith50Cards_WhenTheGameStarts()
        {
            // Arrange
            Deck deck = new Deck();

            // Act

            // Assert
            Assert.Equal(NUMBER_OF_CARDS, deck.Count());
        }

        [Theory]
        [InlineData(1, NUMBER_OF_1_CARDS)]
        [InlineData(2, NUMBER_OF_2_3_4_CARDS)]
        [InlineData(3, NUMBER_OF_2_3_4_CARDS)]
        [InlineData(4, NUMBER_OF_2_3_4_CARDS)]
        [InlineData(5, NUMBER_OF_5_CARDS)]
        public void DeckShouldContain3CardsOfNumberOneForEachColor_WhenTheGameStarts(int cardValue, int expectedNumber)
        {
            // Arrange
            Deck deck = new Deck();

            // Act

            // Assert
            Assert.Equal(expectedNumber, deck.CountCardsOfColorAndValue(CardColors.RED, cardValue));
            Assert.Equal(expectedNumber, deck.CountCardsOfColorAndValue(CardColors.BLUE, cardValue));
            Assert.Equal(expectedNumber, deck.CountCardsOfColorAndValue(CardColors.WHITE, cardValue));
            Assert.Equal(expectedNumber, deck.CountCardsOfColorAndValue(CardColors.GREEN, cardValue));
            Assert.Equal(expectedNumber, deck.CountCardsOfColorAndValue(CardColors.YELLOW, cardValue));
        }

        [Fact]
        public void DeckShouldReturnACardAndContainOneLessCard_WhenItDistributeACard()
        {
            // Arrange
            Deck deck = new Deck();
            int initialCount = deck.Count();

            // Act
            Card card = deck.DistributeCard();

            // Assert
            Assert.Equal(initialCount - 1, deck.Count());
            Assert.NotNull(card);

            //TODO : is it okay to do if statements in tests?
            if (card.value == 1)
            {
                Assert.Equal(NUMBER_OF_1_CARDS - 1, deck.CountCardsOfColorAndValue(card.color, card.value));
            }
            else if (card.value >= 2 || card.value <= 4)
            {
                Assert.Equal(NUMBER_OF_2_3_4_CARDS - 1, deck.CountCardsOfColorAndValue(card.color, card.value));
            }
            else
            {
                Assert.Equal(NUMBER_OF_5_CARDS - 1, deck.CountCardsOfColorAndValue(card.color, card.value));
            }
        }
        
    }
}