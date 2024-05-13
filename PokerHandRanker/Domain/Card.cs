namespace PokerHandRanker.Domain;

public record Card(Rank Rank, Suit Suit)
{
    
    public override string ToString()
    {
        return $"{Rank.ToShortString()}{Suit.ToShortString()}";
    }
}