namespace PokerHandRanker;

public class Card(Rank rank, Suit suit)
{
    public Suit Suit { get; } = suit;
    public Rank Rank { get; } = rank;
    

    public override string ToString()
    {
        return $"{Rank.ToShortString()}{Suit.ToShortString()}";
    }
}