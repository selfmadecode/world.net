namespace World.Net.Countries;

internal sealed class Malawi : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Malawi;

    public string Name { get; } = "Malawi";

    public string OfficialName { get; } = "Republic of Malawi";

    public string NativeName => "Malawi";

    public string Capital { get; } = "Lilongwe";

    public int NumericCode { get; } = 454;

    public string ISO2Code { get; } = "MW";

    public string ISO3Code { get; } = "MWI";

    public string[] CallingCode { get; } = ["+265"];

    public IEnumerable<State> States => new[]
    {
        new State("Central Region", "MW-C", "Region"),
        new State("Northern Region", "MW-N", "Region"),
        new State("Southern Region", "MW-S", "Region")
    };
}

