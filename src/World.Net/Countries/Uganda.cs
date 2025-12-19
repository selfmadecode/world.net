namespace World.Net.Countries;

internal sealed class Uganda : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Uganda;

    public string Name { get; } = "Uganda";

    public string OfficialName { get; } = "Republic of Uganda";

    public string NativeName => "Uganda";

    public string Capital { get; } = "Kampala";

    public int NumericCode { get; } = 800;

    public string ISO2Code { get; } = "UG";

    public string ISO3Code { get; } = "UGA";

    public string[] CallingCode { get; } = ["+256"];

    public IEnumerable<State> States => new[]
    {
        new State("Central", "UG-C", "Region"),
        new State("Eastern", "UG-E", "Region"),
        new State("Northern", "UG-N", "Region"),
        new State("Western", "UG-W", "Region")
    };
}

