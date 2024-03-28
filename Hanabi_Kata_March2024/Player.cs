








namespace Hanabi_Kata_March2024
{
    internal class Player
    {
        public List<Card> hand = new List<Card>();

        public Player(List<Card> PlayersHand)
        {
            hand = PlayersHand;
        }

        internal Card DiscardCard()
        {
            Card discardCard = hand[0];
            hand.RemoveAt(0);
            return discardCard;
        }

        internal Information GiveColorInformation()
        {
            return new Information(new List<int> { 1 }, CardColors.RED);
        }

        internal Information GiveNumberInformation()
        {
            return new Information(new List<int> { 1 }, 1);
        }

        internal void PickACard(Card card)
        {
            hand.Add(card);
        }

        internal Card PlayCard()
        {
            Card playedCard  = hand[0];
            hand.RemoveAt(0);
            return playedCard;
        }
    }
}