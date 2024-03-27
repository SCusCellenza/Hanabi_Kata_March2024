namespace Hanabi_Kata_March2024
{
    public class GameTest
    {
        private Game gameStatus;
        const int MAX_ALLOWED_MISTAKES = 3;
        const int MAX_COMPLETED_SEQUENCES = 5;
        public GameTest()
        {
            // Constructor is called before each test method
            gameStatus = new Game(new Deck());
        }

        [Fact]
        public void IfAMistakeIsMade_ARedTokenIsAddedInTheBox()
        {
            //Arrange
            int initialMistakes = gameStatus.NumberOfMistakesMade;

            //Act
            gameStatus.MistakeIsMade();

            //Assert
            Assert.Equal(1, gameStatus.NumberOfMistakesMade -  initialMistakes);
        }

        [Fact]
        public void IfThreeMistakesAreMade_GameIsOverAndGameIsLost()
        {
            //Arrange

            //Act
            gameStatus.MistakeIsMade();
            gameStatus.MistakeIsMade();
            gameStatus.MistakeIsMade();

            //Assert
            Assert.True(gameStatus.IsOver());
            Assert.True(gameStatus.IsLost());
            Assert.Equal(MAX_ALLOWED_MISTAKES, gameStatus.NumberOfMistakesMade);
        }

        [Fact]
        public void IfLessThanThreeMistakesAreMade_GameIsNotOverAndNotLost()
        {
            //Arrange

            //Act
            gameStatus.MistakeIsMade();

            //Assert
            Assert.False(gameStatus.IsOver());
            Assert.False(gameStatus.IsLost());
            Assert.NotEqual(MAX_ALLOWED_MISTAKES, gameStatus.NumberOfMistakesMade);
        }

        [Fact]
        public void IfAllFiveSequencesAreCompleted_GameIsWonAndOver()
        {
            //Arrange

            //Act
            for (int i = 0; i < MAX_COMPLETED_SEQUENCES; i++)
            {
                gameStatus.ASequenceIsCompleted();
            }

            //Assert
            Assert.True(gameStatus.IsOver());
            Assert.True(gameStatus.IsWon());
            Assert.False(gameStatus.IsLost());
            Assert.Equal(MAX_COMPLETED_SEQUENCES, gameStatus.NumberOfCompletedSequences);
        }

        [Fact]
        public void IfLessThanFiveSequencesAreCompleted_GameIsNotWon()
        {
            //Arrange

            //Act
            gameStatus.ASequenceIsCompleted();

            //Assert
            Assert.False(gameStatus.IsWon());
            Assert.NotEqual(MAX_COMPLETED_SEQUENCES, gameStatus.NumberOfCompletedSequences);
            //No other assert needs to be made, the game can be over or not, lost or not, for this test 
        }

        [Fact]
        public void IfDeckIsEmpty_GameIsInItsLastRound()
        {
            //Arrange 
            Deck deck = new Deck();
            while (deck.Count() > 0)
            {
                deck.DistributeCard();
            }
            Game gameStatus = new Game(deck);

            //Act

            //Assert
            Assert.True(gameStatus.IsInItsLastRound());
        }
    }
}