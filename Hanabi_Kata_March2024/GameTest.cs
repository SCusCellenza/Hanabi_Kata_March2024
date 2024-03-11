namespace Hanabi_Kata_March2024
{
    public class GameTest
    {
        private Game game;
        const int MAX_ALLOWED_MISTAKES = 3;
        const int MAX_COMPLETED_SEQUENCES = 5;
        public GameTest()
        {
            // Constructor is called before each test method
            game = new Game();
        }

        [Fact]
        public void IfAMistakeIsMade_ARedTokenIsAddedInTheBox()
        {
            //Arrange
            int initialMistakes = game.NumberOfMistakesMade;

            //Act
            game.MistakeIsMade();

            //Assert
            Assert.Equal(1, game.NumberOfMistakesMade -  initialMistakes);
        }

        [Fact]
        public void IfThreeMistakesAreMade_GameIsOverAndGameIsLost()
        {
            //Arrange

            //Act
            game.MistakeIsMade();
            game.MistakeIsMade();
            game.MistakeIsMade();

            //Assert
            Assert.True(game.IsOver());
            Assert.True(game.IsLost());
            Assert.Equal(MAX_ALLOWED_MISTAKES, game.NumberOfMistakesMade);
        }

        [Fact]
        public void IfLessThanThreeMistakesAreMade_GameIsNotOverAndNotLost()
        {
            //Arrange

            //Act
            game.MistakeIsMade();

            //Assert
            Assert.False(game.IsOver());
            Assert.False(game.IsLost());
            Assert.NotEqual(MAX_ALLOWED_MISTAKES, game.NumberOfMistakesMade);
        }

        [Fact]
        public void IfAllFiveSequencesAreCompleted_GameIsWonAndOver()
        {
            //Arrange

            //Act
            for (int i = 0; i < MAX_COMPLETED_SEQUENCES; i++)
            {
                game.ASequenceIsCompleted();
            }

            //Assert
            Assert.True(game.IsOver());
            Assert.True(game.IsWon());
            Assert.False(game.IsLost());
            Assert.Equal(MAX_COMPLETED_SEQUENCES, game.NumberOfCompletedSequences);
        }

        [Fact]
        public void IfLessThanFiveSequencesAreCompleted_GameIsNotWon()
        {
            //Arrange

            //Act
            game.ASequenceIsCompleted();

            //Assert
            Assert.False(game.IsWon());
            Assert.NotEqual(MAX_COMPLETED_SEQUENCES, game.NumberOfCompletedSequences);
            //No other assert needs to be made, the game can be over or not, lost or not, for this test 
        }

        [Fact]
        public void IfLastCardOfTheDeckIsPicked_GameIsInItsLastRound()
        {
            //Arrange 

            //Act
            while (game.NumberOfRemainingCardsInTheDeck > 0)
            {
                game.ACardIsPicked();
            }

            //Assert
            Assert.True(game.IsInItsLastRound());
        }

        [Fact]
        public void IfCardsAreAvailableInTheDeck_GameIsNotInItsLastRound()
        {
            //Arrange

            //Act
            while (game.NumberOfRemainingCardsInTheDeck > 10)
            {
                game.ACardIsPicked();
            }

            //Assert
            Assert.False(game.IsInItsLastRound());
            Assert.NotEqual(0, game.NumberOfRemainingCardsInTheDeck);
        }

        [Fact]
        public void IfACardIsPicked_TheNumbersOfRemainingCardsInTheDeckDecreasesByOne()
        {
            //Arrange 
            int numberOfInitialCardsInTheDeck = game.NumberOfRemainingCardsInTheDeck;
            
            //Act 
            game.ACardIsPicked();

            //Assert
            Assert.Equal(1, numberOfInitialCardsInTheDeck - game.NumberOfRemainingCardsInTheDeck);
        }

        [Fact]
        public void IfACardIsPickedAndTheDeckIsEmpty_AnErrorIsThrown()
        {
            //Arrange 
            while (game.NumberOfRemainingCardsInTheDeck > 0)
            {
                game.ACardIsPicked();
            }

            //Act
            Action act = () => game.ACardIsPicked();

            //Assert
            var exception = Assert.Throws<Exception>(act);
            Assert.Equal("Deck is empty, you are not allowed to pick a card", exception.Message);
        }

        [Fact]
        public void IfAllPlayersPlayedDuringLastRound_GameIsOver()
        {
            //Arrange
            //Put the game in last round
            while (game.NumberOfRemainingCardsInTheDeck > 0)
            {
                game.ACardIsPicked();
            }

            //Act
            game.AllPlayersPlayedDuringLastRound = true;

            //Assert
            Assert.True(game.IsOver());
        }
    }
}