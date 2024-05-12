namespace PokerHandRanker;

public class RandomHandFactory
{
    private readonly Card[] _deck = GenerateAllPossibleCards();

    private static Card[] GenerateAllPossibleCards()
    {
        Card[] deck = new Card[52];
        int index = 0;
        
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                deck[index++] = new Card(rank, suit);
            }
        }

        return deck;
    }

    public Hand GetRandomHand()
    {
        Random random = new Random();
        Card[] randomCards = _deck.OrderBy(_ => random.Next()).Take(5).ToArray();
        return new Hand(randomCards);
    }

    public List<Hand> GetRandomHands(int n)
    {
        return Enumerable.Range(0, n).Select(_ => GetRandomHand()).ToList();
    }
}