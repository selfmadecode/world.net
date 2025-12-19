namespace World.Net.Countries;

internal sealed class VirginIslandsBritish : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.VirginIslandsBritish;

    public string Name { get; } = "Virgin Islands (British)";

    public string OfficialName { get; } = "British Virgin Islands";

    public string NativeName => "British Virgin Islands";

    public string Capital { get; } = "Road Town";

    public int NumericCode { get; } = 92;

    public string ISO2Code { get; } = "VG";

    public string ISO3Code { get; } = "VGB";

    public string[] CallingCode { get; } = ["+1-284"];

    public IEnumerable<State> States => Array.Empty<State>();
}
