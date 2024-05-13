namespace PokerHandRanker.Domain;

[Flags]
public enum Suit
{
    Spades = 1,
    Hearts = 2,
    Clubs = 4,
    Diamonds = 8
}

public static class SuitExtensions
{
    public static string ToShortString(this Suit suit)
    {
        return suit switch
        {
            Suit.Spades => "s",
            Suit.Hearts => "h",
            Suit.Clubs => "c",
            Suit.Diamonds => "d",
            _ => throw new ArgumentOutOfRangeException(nameof(suit), suit, null)
        };
    }
}