namespace World.Net.Countries;

internal sealed class TurksAndCaicosIslands : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.TurksAndCaicosIslands;

    public string Name { get; } = "Turks and Caicos Islands";

    public string OfficialName { get; } = "Turks and Caicos Islands";

    public string NativeName => "Turks and Caicos Islands";

    public string Capital { get; } = "Cockburn Town";

    public int NumericCode { get; } = 796;

    public string ISO2Code { get; } = "TC";

    public string ISO3Code { get; } = "TCA";

    public string[] CallingCode { get; } = ["+1-649"];

    public IEnumerable<State> States => Array.Empty<State>();
}
