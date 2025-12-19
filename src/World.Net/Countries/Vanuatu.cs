namespace World.Net.Countries;

internal sealed class Vanuatu : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Vanuatu;

    public string Name { get; } = "Vanuatu";

    public string OfficialName { get; } = "Republic of Vanuatu";

    public string NativeName => "Ripablik blong Vanuatu";

    public string Capital { get; } = "Port Vila";

    public int NumericCode { get; } = 548;

    public string ISO2Code { get; } = "VU";

    public string ISO3Code { get; } = "VUT";

    public string[] CallingCode { get; } = ["+678"];

    public IEnumerable<State> States => new[]
    {
        new State("Malampa", "VU-MAP", "Province"),
        new State("Penama", "VU-PAM", "Province"),
        new State("Sanma", "VU-SAM", "Province"),
        new State("Shefa", "VU-SEE", "Province"),
        new State("Tafea", "VU-TAE", "Province"),
        new State("Torba", "VU-TOB", "Province")
    };
}

