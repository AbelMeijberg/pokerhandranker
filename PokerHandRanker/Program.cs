using PokerHandRanker;

RandomHandFactory factory = new();
List<Hand> randomHands = factory.GetRandomHands(10);

Hand flush = new([
    new Card(Rank.Ace, Suit.Hearts), 
    new Card(Rank.King, Suit.Hearts), 
    new Card(Rank.Queen, Suit.Hearts),
    new Card(Rank.Jack, Suit.Hearts), 
    new Card(Rank.Ten, Suit.Hearts)
]);

Console.WriteLine($"Hand: {flush} is {(flush.IsFLush ? "" : "not ")}a flush");

SingletonArrayHolder arrays = SingletonArrayHolder.Instance;

Console.WriteLine(arrays.Flushes);
