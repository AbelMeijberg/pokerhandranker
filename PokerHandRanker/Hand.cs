namespace PokerHandRanker
{
    public class Hand
    {
        private readonly Card[] _cards;
        private readonly Rank[] _ranks;
        private readonly Suit[] _suits;

        public readonly bool IsFLush;

        public Hand(Card[] cards)
        {
            if (cards.Length != 5)
            {
                throw new ArgumentException("A hand must consist of exactly 5 cards.");
            }

            _cards = cards;
            _ranks = cards.Select(card => card.Rank).ToArray();
            _suits = cards.Select(card => card.Suit).ToArray();
            IsFLush = CheckFlush();
        }

        private bool CheckFlush()
        {
            return _suits.Aggregate((current, next) => current & next) != 0;
        }

        private bool CheckFiveUniqueRanks()
        {
            return true;
        }
        
        public override string ToString()
        {
            return String.Join(" ", _cards.Select(x => x.ToString()));
        }
        
        
    }
}