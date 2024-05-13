namespace PokerHandRanker.Domain;

public enum Rank
{
    Ace = 4096,
    King = 2048,
    Queen = 1024,
    Jack = 512,
    Ten = 256,
    Nine = 128,
    Eight = 64,
    Seven = 32,
    Six = 16,
    Five = 8,
    Four = 4,
    Three = 2,
    Two = 1
}

public static class RankExtensions
{
    public static string ToShortString(this Rank rank)
    {
        return rank switch
        {
            Rank.Ace => "A",
            Rank.King => "K",
            Rank.Queen => "Q",
            Rank.Jack => "J",
            Rank.Ten => "10",
            Rank.Nine => "9",
            Rank.Eight => "8",
            Rank.Seven => "7",
            Rank.Six => "6",
            Rank.Five => "5",
            Rank.Four => "4",
            Rank.Three => "3",
            Rank.Two => "2",
            _ => throw new ArgumentOutOfRangeException(nameof(rank), rank, null)
        };
    }
}