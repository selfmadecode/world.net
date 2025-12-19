namespace World.Net.Countries;

internal sealed class UnitedStatesMinorOutlyingIslands : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.UnitedStatesMinorOutlyingIslands;

    public string Name { get; } = "United States Minor Outlying Islands";

    public string OfficialName { get; } = "United States Minor Outlying Islands";

    public string NativeName => "United States Minor Outlying Islands";

    public string Capital { get; } = null;

    public int NumericCode { get; } = 581;

    public string ISO2Code { get; } = "UM";

    public string ISO3Code { get; } = "UMI";

    public string[] CallingCode { get; } = ["+1"];

    public IEnumerable<State> States => Array.Empty<State>();
}
