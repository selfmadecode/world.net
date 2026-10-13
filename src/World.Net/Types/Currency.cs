namespace World.Net.Types;

/// <summary>
/// Represents currency information for a country.
/// </summary>
public sealed class Currency
{
    public string Code { get; }
    public string Name { get; }
    public string Symbol { get; }

    public Currency(string code, string name, string symbol)
    {
        Code = code;
        Name = name;
        Symbol = symbol;
    }
}
