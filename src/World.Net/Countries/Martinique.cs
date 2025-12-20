namespace World.Net.Countries;

internal sealed class Martinique : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Martinique;

    public string Name { get; } = "Martinique";

    public string OfficialName { get; } = "Martinique";

    public string NativeName => "Martinique";

    public string Capital { get; } = "Fort-de-France";

    public int NumericCode { get; } = 474;

    public string ISO2Code { get; } = "MQ";

    public string ISO3Code { get; } = "MTQ";

    public string[] CallingCode { get; } = ["+596"];

    public IEnumerable<State> States => Array.Empty<State>();
}

