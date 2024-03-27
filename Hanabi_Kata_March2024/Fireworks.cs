

namespace Hanabi_Kata_March2024
{
    //TODO Rename this class
    internal class Fireworks
    {
        private Dictionary<CardColors, int> playedCard;
        public Fireworks()
        {
            playedCard = new Dictionary<CardColors, int>()
            {
                { CardColors.RED, 0 },
                { CardColors.BLUE, 0 },
                { CardColors.WHITE, 0 },
                { CardColors.GREEN, 0 },
                { CardColors.YELLOW, 0 }
            };
        }

        //TODO : couldn't this be replaced by a property ?
        internal int Count()
        {
            int score = 0;
            foreach (var item in playedCard) {
                score += item.Value;
            }
            return score;
        }

        internal void TryToPlayCard(Card card)
        {
            if (playedCard[card.color] + 1 == card.value)
            {
                playedCard[card.color] = card.value;
                return;
            }
            
            throw new Exception("Wrong card played");
        }
    }
}