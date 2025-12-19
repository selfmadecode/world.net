namespace World.Net.Countries;

internal sealed class UnitedKingdom : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.UnitedKingdom;

    public string Name { get; } = "United Kingdom";

    public string OfficialName { get; } = "United Kingdom of Great Britain and Northern Ireland";

    public string NativeName => "United Kingdom";

    public string Capital { get; } = "London";

    public int NumericCode { get; } = 826;

    public string ISO2Code { get; } = "GB";

    public string ISO3Code { get; } = "GBR";

    public string[] CallingCode { get; } = ["+44"];

    public IEnumerable<State> States => new[]
    {
        new State("England", "GB-ENG", "Country"),
        new State("Scotland", "GB-SCT", "Country"),
        new State("Wales", "GB-WLS", "Country"),
        new State("Northern Ireland", "GB-NIR", "Country")
    };
}

