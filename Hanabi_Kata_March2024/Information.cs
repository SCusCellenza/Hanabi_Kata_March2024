namespace Hanabi_Kata_March2024
{
    internal class Information
    {
        public List<int> Positions { get; set; }
        public CardColors Color { get; set; }
        public int CardNumber { get; set; }

        public Information(List<int> positions, CardColors color)
        {
            Positions = positions;
            Color = color;
        }
        public Information(List<int> positions, int cardNumber)
        {
            Positions = positions;
            CardNumber = cardNumber;
        }
    }
}