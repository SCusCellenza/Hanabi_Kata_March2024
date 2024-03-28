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
            List<Player> players = new List<Player> {
                new Player(new List<Card> { }),
                new Player(new List<Card> { })
            };
            game = new Game(new Deck(), players);
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
        public void IfDeckIsEmpty_GameIsInItsLastRound()
        {
            //Arrange 
            Deck deck = new Deck();
            while (deck.Count() > 0)
            {
                deck.DistributeCard();
            }
            List<Player> players = new List<Player> {
                new Player(new List<Card> { }),
                new Player(new List<Card> { })
            };
            Game game = new Game(deck, players);

            //Act

            //Assert
            Assert.True(game.IsInItsLastRound());
        }

        [Fact]
        public void WhenGameIsCreated_ThenAListOfPlayersIsInitialized()
        {
            //Arrange

            //Act

            //Assert
            Assert.NotNull(game.Players);
        }
    }
}