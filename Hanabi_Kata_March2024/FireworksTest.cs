
namespace Hanabi_Kata_March2024
{
    public class FireworksTest
    {
        private Fireworks fireworks;
        public FireworksTest() 
        { 
            fireworks = new Fireworks();
        }
        [Fact]
        public void IfNoCardWasCorrectlyPlayed_ScoreEqualsZero()
        {
            //Arrange

            //Act

            //Assert
            Assert.Equal(0, fireworks.Count());
        }

        [Fact]
        public void IfAllCardWereCorrectlyPlayed_ScoreEquals25()
        {
            //Arrange

            //Act
            for (int i = 0; i < 5; i++)
            {
                fireworks.TryToPlayCard(new Card(i+1, CardColors.RED));
                fireworks.TryToPlayCard(new Card(i+1, CardColors.YELLOW));
                fireworks.TryToPlayCard(new Card(i+1, CardColors.BLUE));
                fireworks.TryToPlayCard(new Card(i+1, CardColors.WHITE));
                fireworks.TryToPlayCard(new Card(i+1, CardColors.GREEN));
            }

            //Assert
            Assert.Equal(25, fireworks.Count());
        }

        [Fact]
        public void IfAnAuthorizedCardIsPlayedTwice_ScoreIncreasesByTwo()
        {
            //Arrange 
            int initialScore = fireworks.Count();

            //Act
            fireworks.TryToPlayCard(new Card(1, CardColors.RED));
            fireworks.TryToPlayCard(new Card(2, CardColors.RED));

            //Assert 
            Assert.Equal(2, fireworks.Count() - initialScore);
        }

        [Fact]
        public void IfAnUnauthorizedCardIsPlayed_ScoreDoesntIncreaseAndExceptionIsThrown()
        {
            //Arrange
            int initialScore = fireworks.Count();

            //Act 
            Action act = () => fireworks.TryToPlayCard(new Card(2, CardColors.RED));
            var exception = Assert.Throws<Exception>(act);

            //Assert 
            Assert.Equal("Wrong card played", exception.Message);
            Assert.Equal(0, fireworks.Count() - initialScore);
        }

    }
}
