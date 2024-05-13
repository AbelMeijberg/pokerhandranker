using System.Reflection.Metadata;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PokerHandRanker;

public record ArrayCollection(
    [property:JsonPropertyName("flushes")] int[] Flushes, 
    [property:JsonPropertyName("unique")] int[] Unique
    );


public class SingletonArrayHolder
{
    private static readonly Lazy<SingletonArrayHolder> Lazy = new(() => new SingletonArrayHolder());
    public static SingletonArrayHolder Instance => Lazy.Value;
    public int[] Flushes { get; private set; }
    public int[] Unique { get; private set; }
    
    private SingletonArrayHolder()
    {
        using var arrayStream = File.OpenRead("arrays.json");
        ArrayCollection arrays = JsonSerializer.Deserialize<ArrayCollection>(arrayStream)!;

        Flushes = arrays.Flushes;
        Unique = arrays.Unique;
    }
}

// json loader met ArrayCollection is generic and algemene stream als parameter