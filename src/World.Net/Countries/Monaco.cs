namespace World.Net.Countries;

internal sealed class Monaco : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Monaco;

    public string Name { get; } = "Monaco";

    public string OfficialName { get; } = "Principality of Monaco";

    public string NativeName => "Principauté de Monaco";

    public string Capital { get; } = "Monaco";

    public int NumericCode { get; } = 492;

    public string ISO2Code { get; } = "MC";

    public string ISO3Code { get; } = "MCO";

    public string[] CallingCode { get; } = ["+377"];

    public IEnumerable<State> States => Array.Empty<State>();
}

