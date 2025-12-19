namespace World.Net.Countries;

internal sealed class Tonga : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Tonga;

    public string Name { get; } = "Tonga";

    public string OfficialName { get; } = "Kingdom of Tonga";

    public string NativeName => "Tonga";

    public string Capital { get; } = "Nukuʻalofa";

    public int NumericCode { get; } = 776;

    public string ISO2Code { get; } = "TO";

    public string ISO3Code { get; } = "TON";

    public string[] CallingCode { get; } = ["+676"];

    public IEnumerable<State> States => new[]
    {
        new State("Haʻapai", "TO-02", "Division"),
        new State("Tongatapu", "TO-01", "Division"),
        new State("Vavaʻu", "TO-05", "Division"),
        new State("Eua", "TO-03", "Division"),
        new State("Niuas", "TO-04", "Division")
    };
}

