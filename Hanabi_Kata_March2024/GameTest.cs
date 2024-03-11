namespace Hanabi_Kata_March2024
{
    public class GameTest
    {
        [Fact]
        public void IfAMistakeIsMade_ARedTokenIsAddedInTheBox()
        {
            //Arrange
            Game game = new Game();
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
            Game game = new Game();

            //Act
            game.MistakeIsMade();
            game.MistakeIsMade();
            game.MistakeIsMade();

            //Assert
            Assert.True(game.IsOver());
            Assert.True(game.IsLost());
            Assert.Equal(3, game.NumberOfMistakesMade);
        }

        [Fact]
        public void IfLessThanThreeMistakesAreMade_GameIsNotOverAndNotLost()
        {
            //Arrange
            Game game = new Game();

            //Act
            game.MistakeIsMade();

            //Assert
            Assert.False(game.IsOver());
            Assert.False(game.IsLost());
            Assert.NotEqual(3, game.NumberOfMistakesMade);
        }

        [Fact]
        public void IfAllFiveCardSequencesAreCompleted_GameIsWonAndOver()
        {
            //Arrange
            Game game = new Game();

            //Act
            game.ASequenceIsCompleted();
            game.ASequenceIsCompleted();
            game.ASequenceIsCompleted();
            game.ASequenceIsCompleted();
            game.ASequenceIsCompleted();

            //Assert
            Assert.True(game.IsOver());
            Assert.True(game.IsWon());
            Assert.False(game.IsLost());
            Assert.Equal(5, game.NumberOfCompletedSequences);
        }
    }
}