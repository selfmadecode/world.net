namespace World.Net.Countries;

internal sealed class FaroeIslands : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.FaroeIslands;

    //<inheritdoc/>
    public string Name { get; } = "Faroe Islands";

    //<inheritdoc/>
    public string OfficialName { get; } = "Faroe Islands";

    //<inheritdoc/>
    public string NativeName => "Føroyar";

    //<inheritdoc/>
    public string Capital { get; } = "Tórshavn";

    //<inheritdoc/>
    public int NumericCode { get; } = 234;

    //<inheritdoc/>
    public string ISO2Code { get; } = "FO";

    //<inheritdoc/>
    public string ISO3Code { get; } = "FRO";

    //<inheritdoc/>
    public string CallingCode { get; } = "+298";

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Eysturoy", "FO-01", "Region"),
        new("Norðoyar", "FO-02", "Region"),
        new("Sandoy", "FO-03", "Region"),
        new("Streymoy", "FO-04", "Region"),
        new("Suðuroy", "FO-05", "Region"),
        new("Vágar", "FO-06", "Region")
    ];
}
