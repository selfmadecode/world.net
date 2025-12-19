namespace World.Net.Countries;

internal sealed class TheGambia : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Gambia;

    public string Name { get; } = "The Gambia";

    public string OfficialName { get; } = "Republic of The Gambia";

    public string NativeName => "The Gambia";

    public string Capital { get; } = "Banjul";

    public int NumericCode { get; } = 270;

    public string ISO2Code { get; } = "GM";

    public string ISO3Code { get; } = "GMB";

    public string[] CallingCode { get; } = ["+220"];

    public IEnumerable<State> States => new[]
    {
        new State("Banjul", "GM-B", "City"),
        new State("Central River", "GM-CR", "Region"),
        new State("Lower River", "GM-LR", "Region"),
        new State("North Bank", "GM-NB", "Region"),
        new State("Upper River", "GM-UR", "Region"),
        new State("Western", "GM-W", "Region")
    };
}

