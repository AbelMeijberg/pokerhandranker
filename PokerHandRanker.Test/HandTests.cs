using PokerHandRanker;

namespace PokerHandRanker.Test;

public class HandTests
{
    [Fact]
    public void CheckFlush_ReturnsTrue_WhenAllSuitsAreSame()
    {
        Card[] cards = 
        {
            new(Rank.Ace, Suit.Hearts),
            new(Rank.Two, Suit.Hearts),
            new(Rank.Three, Suit.Hearts),
            new(Rank.Four, Suit.Hearts),
            new(Rank.Five, Suit.Hearts),
        };
        Hand hand = new Hand(cards);

        Assert.True(hand.IsFLush);
    }

    [Fact]
    public void CheckFlush_ReturnsFalse_WhenNotAllSuitsAreSame()
    {
        Card[] cards =
        {
            new(Rank.Ace, Suit.Hearts),
            new(Rank.Two, Suit.Hearts),
            new(Rank.Three, Suit.Diamonds),
            new(Rank.Four, Suit.Hearts),
            new(Rank.Five, Suit.Hearts),
        };
        var hand = new Hand(cards);
        
        Assert.False(hand.IsFLush);
    }
}